using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OrderManagement.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "onie.langosh1@phyllis.net", "آنوشا", "علم" },
                    { 2, "devante.lakin2@daren.info", "پرناز", "میرزاده" },
                    { 3, "briana.robel3@cleora.org", "جهان", "عالی" },
                    { 4, "beau.lehner4@florine.net", "مینو", "کرمانی" },
                    { 5, "moshe.rogahn5@gordon.biz", "فرید", "معارف" },
                    { 6, "joseph.kuhic6@dennis.net", "گلبرگ", "فریاد" },
                    { 7, "isaiah.kuhlman7@merle.info", "آبتین", "مجتبایی" },
                    { 8, "lorine.grimes8@friedrich.org", "دلکش", "قهرمان" },
                    { 9, "luis.morissette9@ila.info", "پولاد", "نیلوفری" },
                    { 10, "merle.bergstrom10@tomas.biz", "آزاده", "محمدرضایی" },
                    { 11, "eusebio.armstrong11@reed.com", "بردیا", "گل محمدی" },
                    { 12, "octavia.hickle12@myrna.net", "نازچهر", "میردامادی" },
                    { 13, "luther.o'hara13@destiny.com", "شاهدخت", "کلباسی" },
                    { 14, "demario.thompson14@kiana.name", "اوستا", "قهرمانی" },
                    { 15, "odessa.aufderhar15@jackie.net", "کارو", "علم" },
                    { 16, "kavon.goldner16@giovanny.biz", "اشکان", "هروی" },
                    { 17, "jalon.morissette17@hermann.name", "بهتاش", "قانعی" },
                    { 18, "beth.watsica18@charley.com", "باپوک", "نقیب‌زاده" },
                    { 19, "drew.nicolas19@zaria.name", "مهوش", "کمالی" },
                    { 20, "rosario.schinner20@harrison.net", "نیک خواه", "فریاد" },
                    { 21, "dortha.bechtelar21@ellsworth.net", "داریا", "نیلوفری" },
                    { 22, "willy.hermann22@kane.com", "پروانه", "فرامرزی" },
                    { 23, "sabina.moore23@percy.net", "کامراوا", "لاهوتی" },
                    { 24, "skyla.prosacco24@celestine.com", "سیمین", "ملک" },
                    { 25, "tristian.upton25@ewell.biz", "شاهپور", "گلپایگانی" },
                    { 26, "romaine.ratke26@fred.name", "شب بو", "کاکاوند" },
                    { 27, "joe.hahn27@ophelia.com", "ساره", "عبدالکریمی" },
                    { 28, "rod.goodwin28@albert.name", "باپوک", "مجتهد شبستری" },
                    { 29, "heber.bogan29@freddy.net", "مژگان", "کاکاوند" },
                    { 30, "marianna.donnelly30@lester.org", "میترا", "محمدی" },
                    { 31, "rene.schoen31@susie.biz", "مینو فر", "قاضی" },
                    { 32, "audreanne.graham32@delores.net", "پریدخت", "هاشمی رفسنجانی" },
                    { 33, "simone.torp33@liana.net", "دانوش", "عنایت" },
                    { 34, "gregg.jacobson34@bradford.com", "خرمدخت", "فتاحی" },
                    { 35, "valentin.botsford35@ryder.net", "ماندانا", "کریمی" },
                    { 36, "hazel.murazik36@isaias.name", "نگین", "فتاحی" },
                    { 37, "laisha.moore37@berneice.com", "تاباندخت", "قنبری" },
                    { 38, "anjali.o'kon38@ricky.biz", "شباهنگ", "مجتهدی" },
                    { 39, "tom.abbott39@vern.info", "مهین دخت", "هومن" },
                    { 40, "brandi.schiller40@amara.name", "شهرناز", "لنکرانی" },
                    { 41, "alivia.gorczany41@gerda.com", "دنیا", "عقیلی" },
                    { 42, "marco.hilll42@maximillian.info", "زونا", "معروف" },
                    { 43, "anabel.gorczany43@verla.name", "بارمان", "معروف" },
                    { 44, "justine.prosacco44@dayna.org", "هور", "علیا" },
                    { 45, "corine.wisozk45@burley.org", "نرمین", "هاشمی رفسنجانی" },
                    { 46, "danny.bayer46@etha.com", "سوبار", "کهنمویی" },
                    { 47, "bette.wunsch47@elwin.biz", "باربد", "فرامرزی" },
                    { 48, "donato.mckenzie48@taya.biz", "فرهود", "مجتبوی" },
                    { 49, "joannie.kuvalis49@rey.org", "سرافراز", "فرهنگ" },
                    { 50, "rhianna.corwin50@gillian.info", "آرش", "مستوفی" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "بدون محدودیت پلاستیکی کفش", 34172265.17m },
                    { 2, "خوش طعم پلاستیکی کامپیوتر", 2126178.57m },
                    { 3, "باور نکردنی استیل ماوس", 39278943.28m },
                    { 4, "براق یخ زده پنیر", 16416221.05m },
                    { 5, "ارگونومیک نرم صابون", 14888108.38m },
                    { 6, "خوش طعم تازه حوله", 46989618.06m },
                    { 7, "کاربردی تازه حوله", 13984310.80m },
                    { 8, "کوچک نرم دوچرخه", 46770067.33m },
                    { 9, "دست ساز فلزی کامپیوتر", 46830945.09m },
                    { 10, "دست ساز تازه کلاه", 48280601.67m },
                    { 11, "کاربردی تازه صندلی", 18917753.24m },
                    { 12, "کوچک نرم چیپس", 42171461.55m },
                    { 13, "باهوش فلزی میز", 3818976.94m },
                    { 14, "براق استیل کلاه", 49510918.86m },
                    { 15, "لطیف گرانیتی ماوس", 3576812.77m },
                    { 16, "دست ساز تازه صندلی", 26649705.58m },
                    { 17, "لطیف بتنی صندلی", 44027847.07m },
                    { 18, "بدون محدودیت تازه صابون", 11780503.47m },
                    { 19, "جذاب فلزی بیکن", 5478327.13m },
                    { 20, "لطیف چوبی سوسیس", 38198786.29m },
                    { 21, "بدون محدودیت نرم کامپیوتر", 17406430.99m },
                    { 22, "باور نکردنی چوبی پیراهن", 34406908.40m },
                    { 23, "ارگونومیک چوبی کیبورد", 9009973.84m },
                    { 24, "معمولی کتان دوچرخه", 32158355.99m },
                    { 25, "بدون محدودیت کتان حوله", 38159586.18m },
                    { 26, "دست ساز چوبی چیپس", 15629849.92m },
                    { 27, "ارگونومیک بتنی پیتزا", 44067117.13m },
                    { 28, "جذاب پلاستیکی کیبورد", 30084605.52m },
                    { 29, "عالی کتان کیبورد", 722875.20m },
                    { 30, "دست ساز فلزی دوچرخه", 33378636.19m },
                    { 31, "لطیف پلاستیکی پنیر", 37684440.13m },
                    { 32, "دست ساز کتان کلاه", 39211751.76m },
                    { 33, "خارق العاده چوبی دوچرخه", 17636090.08m },
                    { 34, "عالی چوبی ماشین", 39493357.37m },
                    { 35, "دست ساز تازه توپ", 5395524.20m },
                    { 36, "باور نکردنی گرانیتی پیراهن", 36300034.48m },
                    { 37, "خوش طعم گرانیتی حوله", 12936796.65m },
                    { 38, "جذاب بتنی سوسیس", 10367864.37m },
                    { 39, "جذاب یخ زده سالاد", 19990451.31m },
                    { 40, "باور نکردنی بتنی صابون", 32698767.04m },
                    { 41, "معمولی استیل میز", 4936615.16m },
                    { 42, "باهوش نرم چیپس", 23014936.83m },
                    { 43, "خارق العاده پلاستیکی توپ", 45692671.53m },
                    { 44, "خارق العاده چوبی شلوار", 16599509.94m },
                    { 45, "بدون محدودیت استیل پنیر", 9006320.39m },
                    { 46, "بدون محدودیت بتنی کلاه", 10489545.76m },
                    { 47, "جذاب استیل ماشین", 36021034.93m },
                    { 48, "جذاب فلزی میز", 26930794.62m },
                    { 49, "باهوش فلزی میز", 12071857.69m },
                    { 50, "کوچک پلاستیکی حوله", 9729329.42m },
                    { 51, "براق استیل پیتزا", 45350746.97m },
                    { 52, "خوش طعم استیل بیکن", 8905447.38m },
                    { 53, "براق گرانیتی کفش", 16276612.61m },
                    { 54, "کاربردی کتان پنیر", 19423514.16m },
                    { 55, "براق بتنی پیتزا", 6140355.18m },
                    { 56, "دست ساز بتنی دوچرخه", 36951114.21m },
                    { 57, "خوش طعم نرم مرغ", 39088014.85m },
                    { 58, "معمولی چوبی توپ", 29366184.02m },
                    { 59, "کاربردی گرانیتی صابون", 38446613.17m },
                    { 60, "خارق العاده گرانیتی توپ", 12210177.60m },
                    { 61, "جذاب تازه ماوس", 33483176.08m },
                    { 62, "باهوش چوبی کامپیوتر", 39492946.39m },
                    { 63, "لطیف استیل مرغ", 40757815.13m },
                    { 64, "کاربردی کتان کفش", 15355956.69m },
                    { 65, "بدون محدودیت چوبی چیپس", 11966249.97m },
                    { 66, "باور نکردنی استیل کلاه", 20335172.10m },
                    { 67, "باور نکردنی یخ زده پیتزا", 43256269.79m },
                    { 68, "لطیف استیل چیپس", 48180106.47m },
                    { 69, "خوش طعم فلزی سالاد", 41581929.10m },
                    { 70, "کوچک گرانیتی صابون", 41756574.04m },
                    { 71, "عالی یخ زده سوسیس", 31277840.46m },
                    { 72, "کاربردی کتان کامپیوتر", 840555.17m },
                    { 73, "ارگونومیک پلاستیکی سالاد", 14245093.97m },
                    { 74, "عالی استیل سوسیس", 9784132.31m },
                    { 75, "خارق العاده نرم شلوار", 12332733.95m },
                    { 76, "جذاب بتنی چیپس", 40589652.34m },
                    { 77, "ارگونومیک نرم بیکن", 43588131.41m },
                    { 78, "براق فلزی دوچرخه", 17517068.74m },
                    { 79, "براق چوبی صابون", 19467242.23m },
                    { 80, "ارگونومیک تازه چیپس", 43087630.92m },
                    { 81, "لطیف تازه پنیر", 24495446.81m },
                    { 82, "ارگونومیک فلزی شلوار", 49310639.41m },
                    { 83, "معمولی نرم میز", 14698952.30m },
                    { 84, "باهوش پلاستیکی صابون", 19982906.88m },
                    { 85, "بدون محدودیت چوبی حوله", 36400671.38m },
                    { 86, "عالی بتنی کفش", 23425533.26m },
                    { 87, "ارگونومیک گرانیتی ماهی", 25145299.33m },
                    { 88, "خارق العاده گرانیتی کامپیوتر", 25446467.33m },
                    { 89, "لطیف کتان میز", 20127662.09m },
                    { 90, "کاربردی کتان مرغ", 19340541.28m },
                    { 91, "خارق العاده تازه دوچرخه", 42418863.50m },
                    { 92, "باهوش یخ زده کیبورد", 10431623.70m },
                    { 93, "براق بتنی کفش", 46748496.47m },
                    { 94, "باور نکردنی بتنی دوچرخه", 27691800.44m },
                    { 95, "خارق العاده بتنی پیراهن", 30463275.77m },
                    { 96, "خوش طعم تازه صابون", 5737442.86m },
                    { 97, "عالی یخ زده کفش", 34599679.22m },
                    { 98, "بدون محدودیت چوبی سوسیس", 21455822.91m },
                    { 99, "کاربردی چوبی شلوار", 40323278.28m },
                    { 100, "کوچک فلزی توپ", 6845226.13m },
                    { 101, "خارق العاده گرانیتی چیپس", 9534089.86m },
                    { 102, "ارگونومیک چوبی ماوس", 29501582.82m },
                    { 103, "جذاب تازه صندلی", 9174852.90m },
                    { 104, "ارگونومیک استیل میز", 27785456.45m },
                    { 105, "جذاب استیل توپ", 13016707.23m },
                    { 106, "کاربردی کتان دستکش", 17839219.83m },
                    { 107, "جذاب استیل کفش", 8330074.11m },
                    { 108, "بدون محدودیت کتان کلاه", 38367986.62m },
                    { 109, "کوچک بتنی دوچرخه", 21173651.73m },
                    { 110, "بدون محدودیت پلاستیکی صندلی", 20211166.55m },
                    { 111, "دست ساز تازه میز", 49615647.87m },
                    { 112, "باهوش نرم شلوار", 20238888.30m },
                    { 113, "دست ساز نرم حوله", 46921301.87m },
                    { 114, "باور نکردنی استیل تن ماهی", 44690065.73m },
                    { 115, "باهوش فلزی سالاد", 2957407.69m },
                    { 116, "دست ساز استیل مرغ", 42468569.53m },
                    { 117, "خارق العاده بتنی کیبورد", 40602659.13m },
                    { 118, "لطیف استیل مرغ", 42500530.31m },
                    { 119, "ارگونومیک تازه کلاه", 29362641.76m },
                    { 120, "کوچک پلاستیکی ماوس", 27058794.98m },
                    { 121, "معمولی استیل میز", 5258100.15m },
                    { 122, "بدون محدودیت گرانیتی پیراهن", 341083.87m },
                    { 123, "عالی پلاستیکی دوچرخه", 13349686.73m },
                    { 124, "کاربردی یخ زده مرغ", 37215666.74m },
                    { 125, "باهوش گرانیتی صابون", 45763035.44m },
                    { 126, "عالی گرانیتی حوله", 36031355.12m },
                    { 127, "ارگونومیک نرم پیتزا", 24738937.82m },
                    { 128, "براق استیل پیتزا", 44358094.48m },
                    { 129, "خارق العاده پلاستیکی شلوار", 32704647.27m },
                    { 130, "عالی گرانیتی چیپس", 39870693.08m },
                    { 131, "لطیف چوبی ماوس", 23717001.51m },
                    { 132, "لطیف کتان شلوار", 5397352.45m },
                    { 133, "باهوش نرم پیراهن", 23832212.62m },
                    { 134, "معمولی بتنی چیپس", 8304042.70m },
                    { 135, "کاربردی نرم صندلی", 7461488.58m },
                    { 136, "دست ساز یخ زده کفش", 26638242.97m },
                    { 137, "براق پلاستیکی پیتزا", 6517017.06m },
                    { 138, "عالی استیل کیبورد", 29423364.89m },
                    { 139, "عالی تازه ماشین", 21148955.82m },
                    { 140, "باور نکردنی چوبی سوسیس", 34218999.23m },
                    { 141, "باور نکردنی نرم دستکش", 37759963.72m },
                    { 142, "معمولی پلاستیکی ماوس", 7246504.26m },
                    { 143, "خارق العاده بتنی ماوس", 43315229.40m },
                    { 144, "عالی تازه ماشین", 45922424.69m },
                    { 145, "معمولی فلزی چیپس", 23946475.45m },
                    { 146, "براق بتنی کلاه", 7044603.51m },
                    { 147, "عالی تازه سالاد", 44689116.50m },
                    { 148, "باهوش گرانیتی پیتزا", 18736880.54m },
                    { 149, "لطیف پلاستیکی بیکن", 47743890.17m },
                    { 150, "عالی نرم پیتزا", 6898868.54m },
                    { 151, "باهوش نرم ماهی", 20113238.38m },
                    { 152, "بدون محدودیت بتنی چیپس", 37047847.96m },
                    { 153, "دست ساز چوبی پنیر", 32959030.57m },
                    { 154, "ارگونومیک کتان کامپیوتر", 6296396.17m },
                    { 155, "جذاب چوبی کیبورد", 43083288.72m },
                    { 156, "کاربردی بتنی سوسیس", 43355737.68m },
                    { 157, "خارق العاده نرم ماشین", 13957493.93m },
                    { 158, "کوچک چوبی دستکش", 46414778.11m },
                    { 159, "لطیف تازه دستکش", 43216682.60m },
                    { 160, "براق چوبی توپ", 14853143.96m },
                    { 161, "لطیف چوبی کیبورد", 1992989.63m },
                    { 162, "دست ساز چوبی دوچرخه", 17739510.04m },
                    { 163, "باهوش فلزی مرغ", 20896795.10m },
                    { 164, "عالی یخ زده تن ماهی", 43248813.73m },
                    { 165, "دست ساز تازه صندلی", 3249337.06m },
                    { 166, "جذاب نرم مرغ", 30423303.46m },
                    { 167, "لطیف تازه پیتزا", 15436406.74m },
                    { 168, "ارگونومیک بتنی صابون", 7654326.14m },
                    { 169, "بدون محدودیت تازه صندلی", 16295422.60m },
                    { 170, "ارگونومیک یخ زده کامپیوتر", 9321055.06m },
                    { 171, "براق نرم ماشین", 18998390.51m },
                    { 172, "خارق العاده یخ زده شلوار", 40992899.81m },
                    { 173, "باهوش کتان کامپیوتر", 32394981.64m },
                    { 174, "کوچک بتنی ماشین", 5465170.84m },
                    { 175, "کاربردی گرانیتی ماوس", 47732564.21m },
                    { 176, "باور نکردنی یخ زده دوچرخه", 47668964.18m },
                    { 177, "کوچک گرانیتی کلاه", 35592287.50m },
                    { 178, "خوش طعم پلاستیکی ماهی", 42527224.26m },
                    { 179, "دست ساز تازه کفش", 25487293.76m },
                    { 180, "عالی پلاستیکی ماوس", 46822323.38m },
                    { 181, "کاربردی استیل کیبورد", 32253964.28m },
                    { 182, "باهوش یخ زده کامپیوتر", 34522317.35m },
                    { 183, "لطیف یخ زده پیتزا", 28704345.23m },
                    { 184, "معمولی چوبی پیتزا", 31931070.04m },
                    { 185, "کاربردی چوبی دستکش", 43990546.29m },
                    { 186, "خارق العاده فلزی پیتزا", 41864524.58m },
                    { 187, "دست ساز بتنی پیتزا", 10727478.48m },
                    { 188, "دست ساز گرانیتی کفش", 7441205.62m },
                    { 189, "خارق العاده بتنی کفش", 15470431.30m },
                    { 190, "لطیف گرانیتی بیکن", 4010129.48m },
                    { 191, "کاربردی تازه سالاد", 1277935.85m },
                    { 192, "کاربردی چوبی کیبورد", 32144416.64m },
                    { 193, "کوچک تازه صندلی", 26014634.93m },
                    { 194, "خوش طعم پلاستیکی حوله", 41821274.42m },
                    { 195, "باهوش بتنی سوسیس", 44513727.71m },
                    { 196, "ارگونومیک تازه چیپس", 11882465.36m },
                    { 197, "کاربردی نرم ماوس", 22422397.39m },
                    { 198, "معمولی گرانیتی پیتزا", 43816304.06m },
                    { 199, "باور نکردنی بتنی میز", 28430541.91m },
                    { 200, "دست ساز تازه شلوار", 27936607.54m }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 66 },
                    { 2, 2, 124 },
                    { 3, 3, 113 },
                    { 4, 4, 429 },
                    { 5, 5, 268 },
                    { 6, 6, 475 },
                    { 7, 7, 89 },
                    { 8, 8, 44 },
                    { 9, 9, 361 },
                    { 10, 10, 325 },
                    { 11, 11, 82 },
                    { 12, 12, 252 },
                    { 13, 13, 343 },
                    { 14, 14, 460 },
                    { 15, 15, 491 },
                    { 16, 16, 299 },
                    { 17, 17, 426 },
                    { 18, 18, 343 },
                    { 19, 19, 284 },
                    { 20, 20, 379 },
                    { 21, 21, 483 },
                    { 22, 22, 350 },
                    { 23, 23, 496 },
                    { 24, 24, 235 },
                    { 25, 25, 17 },
                    { 26, 26, 87 },
                    { 27, 27, 111 },
                    { 28, 28, 370 },
                    { 29, 29, 443 },
                    { 30, 30, 490 },
                    { 31, 31, 64 },
                    { 32, 32, 167 },
                    { 33, 33, 467 },
                    { 34, 34, 187 },
                    { 35, 35, 390 },
                    { 36, 36, 434 },
                    { 37, 37, 334 },
                    { 38, 38, 68 },
                    { 39, 39, 358 },
                    { 40, 40, 263 },
                    { 41, 41, 282 },
                    { 42, 42, 74 },
                    { 43, 43, 368 },
                    { 44, 44, 14 },
                    { 45, 45, 204 },
                    { 46, 46, 183 },
                    { 47, 47, 106 },
                    { 48, 48, 203 },
                    { 49, 49, 142 },
                    { 50, 50, 415 },
                    { 51, 51, 363 },
                    { 52, 52, 32 },
                    { 53, 53, 148 },
                    { 54, 54, 310 },
                    { 55, 55, 301 },
                    { 56, 56, 216 },
                    { 57, 57, 128 },
                    { 58, 58, 379 },
                    { 59, 59, 422 },
                    { 60, 60, 190 },
                    { 61, 61, 373 },
                    { 62, 62, 219 },
                    { 63, 63, 101 },
                    { 64, 64, 372 },
                    { 65, 65, 270 },
                    { 66, 66, 415 },
                    { 67, 67, 285 },
                    { 68, 68, 166 },
                    { 69, 69, 80 },
                    { 70, 70, 66 },
                    { 71, 71, 466 },
                    { 72, 72, 368 },
                    { 73, 73, 485 },
                    { 74, 74, 30 },
                    { 75, 75, 107 },
                    { 76, 76, 419 },
                    { 77, 77, 482 },
                    { 78, 78, 491 },
                    { 79, 79, 40 },
                    { 80, 80, 334 },
                    { 81, 81, 482 },
                    { 82, 82, 408 },
                    { 83, 83, 238 },
                    { 84, 84, 38 },
                    { 85, 85, 137 },
                    { 86, 86, 41 },
                    { 87, 87, 28 },
                    { 88, 88, 166 },
                    { 89, 89, 387 },
                    { 90, 90, 183 },
                    { 91, 91, 315 },
                    { 92, 92, 456 },
                    { 93, 93, 146 },
                    { 94, 94, 177 },
                    { 95, 95, 390 },
                    { 96, 96, 72 },
                    { 97, 97, 473 },
                    { 98, 98, 497 },
                    { 99, 99, 244 },
                    { 100, 100, 289 },
                    { 101, 101, 398 },
                    { 102, 102, 441 },
                    { 103, 103, 133 },
                    { 104, 104, 85 },
                    { 105, 105, 450 },
                    { 106, 106, 495 },
                    { 107, 107, 48 },
                    { 108, 108, 127 },
                    { 109, 109, 213 },
                    { 110, 110, 382 },
                    { 111, 111, 235 },
                    { 112, 112, 138 },
                    { 113, 113, 349 },
                    { 114, 114, 98 },
                    { 115, 115, 209 },
                    { 116, 116, 466 },
                    { 117, 117, 481 },
                    { 118, 118, 73 },
                    { 119, 119, 245 },
                    { 120, 120, 239 },
                    { 121, 121, 397 },
                    { 122, 122, 128 },
                    { 123, 123, 280 },
                    { 124, 124, 397 },
                    { 125, 125, 251 },
                    { 126, 126, 20 },
                    { 127, 127, 231 },
                    { 128, 128, 318 },
                    { 129, 129, 141 },
                    { 130, 130, 44 },
                    { 131, 131, 446 },
                    { 132, 132, 486 },
                    { 133, 133, 256 },
                    { 134, 134, 251 },
                    { 135, 135, 437 },
                    { 136, 136, 51 },
                    { 137, 137, 285 },
                    { 138, 138, 163 },
                    { 139, 139, 88 },
                    { 140, 140, 142 },
                    { 141, 141, 494 },
                    { 142, 142, 402 },
                    { 143, 143, 454 },
                    { 144, 144, 14 },
                    { 145, 145, 449 },
                    { 146, 146, 187 },
                    { 147, 147, 116 },
                    { 148, 148, 58 },
                    { 149, 149, 468 },
                    { 150, 150, 425 },
                    { 151, 151, 91 },
                    { 152, 152, 410 },
                    { 153, 153, 262 },
                    { 154, 154, 15 },
                    { 155, 155, 393 },
                    { 156, 156, 279 },
                    { 157, 157, 171 },
                    { 158, 158, 237 },
                    { 159, 159, 334 },
                    { 160, 160, 440 },
                    { 161, 161, 273 },
                    { 162, 162, 231 },
                    { 163, 163, 487 },
                    { 164, 164, 178 },
                    { 165, 165, 437 },
                    { 166, 166, 250 },
                    { 167, 167, 382 },
                    { 168, 168, 107 },
                    { 169, 169, 161 },
                    { 170, 170, 168 },
                    { 171, 171, 190 },
                    { 172, 172, 328 },
                    { 173, 173, 486 },
                    { 174, 174, 112 },
                    { 175, 175, 245 },
                    { 176, 176, 495 },
                    { 177, 177, 175 },
                    { 178, 178, 275 },
                    { 179, 179, 448 },
                    { 180, 180, 74 },
                    { 181, 181, 404 },
                    { 182, 182, 183 },
                    { 183, 183, 350 },
                    { 184, 184, 216 },
                    { 185, 185, 453 },
                    { 186, 186, 46 },
                    { 187, 187, 234 },
                    { 188, 188, 251 },
                    { 189, 189, 359 },
                    { 190, 190, 167 },
                    { 191, 191, 381 },
                    { 192, 192, 57 },
                    { 193, 193, 329 },
                    { 194, 194, 149 },
                    { 195, 195, 369 },
                    { 196, 196, 273 },
                    { 197, 197, 416 },
                    { 198, 198, 285 },
                    { 199, 199, 78 },
                    { 200, 200, 209 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200);
        }
    }
}
