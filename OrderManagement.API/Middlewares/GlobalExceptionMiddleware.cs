using Microsoft.AspNetCore.Mvc;
using OrderManagement.Application.Exceptions;
using OrderManagement.Domain.Exceptions;

namespace OrderManagement.API.Middlewares
{
    public class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionMiddleware> _logger;

        public GlobalExceptionMiddleware(RequestDelegate next,ILogger<GlobalExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (OperationCanceledException) when (context.RequestAborted.IsCancellationRequested)
            {
                _logger.LogDebug("Request was cancelled by the client. TraceId: {TraceId}",context.TraceIdentifier);
            }
            catch (Exception exception)
            {
                if (context.Response.HasStarted)
                    throw;

                var problem = CreateProblemDetails(context, exception);

                if (problem.Status >= 500)
                {
                    _logger.LogError(
                        exception,
                        "Unhandled exception. Method: {Method}, Path: {Path}, StatusCode: {StatusCode}, TraceId: {TraceId}",
                        context.Request.Method,
                        context.Request.Path,
                        problem.Status,
                        context.TraceIdentifier);
                }
                else
                {
                    _logger.LogWarning(
                        "Request failed. Method: {Method}, Path: {Path}, StatusCode: {StatusCode}, Exception: {ExceptionType}, Message: {Message}, TraceId: {TraceId}",
                        context.Request.Method,
                        context.Request.Path,
                        problem.Status,
                        exception.GetType().Name,
                        exception.Message,
                        context.TraceIdentifier);
                }

                await WriteProblemDetailsAsync(context, problem);
            }
        }

        private static ProblemDetails CreateProblemDetails(HttpContext context,Exception exception)
        {
            var (statusCode, title, detail) = exception switch
            {
                OrderNotFoundException =>
                    (404, "Order Not Found", exception.Message),

                ProductNotFoundException =>
                    (404, "Product Not Found", exception.Message),

                InvalidOrderStatusException =>
                    (409, "Invalid Order Status", exception.Message),

                UnauthorizedAccessException =>
                    (403, "Forbidden",
                     "You do not have permission to perform this operation."),

                ArgumentException =>
                    (400, "Bad Request", exception.Message),

                _ =>
                    (500, "Internal Server Error",
                     "An unexpected error occurred. Please try again later.")
            };

            var problem = new ProblemDetails
            {
                Status = statusCode,
                Title = title,
                Detail = detail,
                Instance = context.Request.Path
            };

            problem.Extensions["traceId"] = context.TraceIdentifier;

            return problem;
        }

        private static async Task WriteProblemDetailsAsync(HttpContext context,ProblemDetails problem)
        {
            context.Response.Clear();
            context.Response.StatusCode = problem.Status!.Value;
            context.Response.ContentType = "application/problem+json";

            await context.Response.WriteAsJsonAsync(problem, cancellationToken: context.RequestAborted);
        }
    }
}
