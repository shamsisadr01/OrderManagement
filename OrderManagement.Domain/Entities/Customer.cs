using OrderManagement.Domain.Enums;

namespace OrderManagement.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; private set; } = null!;

        public string LastName { get; private set; } = null!;

        public string Email { get; private set; } = null!;

        public string PasswordHash { get; private set; } = null!;

        public UserRole Role { get; private set; } = UserRole.Customer;

        public ICollection<Order> Orders { get; private set; }
            = new List<Order>();

        private Customer()
        {
        }

        public Customer(
            string firstName,
            string lastName,
            string email,
            string passwordHash,
            UserRole role = UserRole.Customer)
        {
            Guard(firstName, lastName, email);

            if (string.IsNullOrWhiteSpace(passwordHash))
                throw new ArgumentException("Password is required.");

            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PasswordHash = passwordHash;
            Role = role;
        }

        public void UpdateInformation(
            string firstName,
            string lastName,
            string email)
        {
            Guard(firstName, lastName, email);

            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public void ChangePassword(string passwordHash)
        {
            if (string.IsNullOrWhiteSpace(passwordHash))
                throw new ArgumentException("Password is required.");

            PasswordHash = passwordHash;
        }

        public void ChangeRole(UserRole role)
        {
            Role = role;
        }

        private void Guard(
            string firstName,
            string lastName,
            string email)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("First name is required.");

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Last name is required.");

            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email is required.");
        }
    }
}
