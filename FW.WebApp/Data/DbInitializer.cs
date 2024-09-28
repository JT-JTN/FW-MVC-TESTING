using FW.CoreBusiness;

namespace FW.WebApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Clients.
            if (context.Clients.Any())
                return;   // DB has been seeded

            var clients = new Client[]
            {
                new Client {FirstName = "Jeniece", LastName = "Gremane", EmailAddress = "jgremane0@tamu.edu", PhoneNumber = "5315383774", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"},
                new Client {FirstName = "Xena", LastName = "Swiggs", EmailAddress = "xswiggs1@omniture.com", PhoneNumber = "4194801737", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"},
                new Client {FirstName = "Fredelia", LastName = "Straughan", EmailAddress = "fstraughan2@utexas.edu", PhoneNumber = "1508012182", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"},
                new Client {FirstName = "Antin", LastName = "Floyde", EmailAddress = "afloyde3@cornell.edu", PhoneNumber = "9804840438", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"},
                new Client {FirstName = "Cullen", LastName = "Berks", EmailAddress = "cberks4@last.fm", PhoneNumber = "6136475304", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"},
                new Client {FirstName = "Lena", LastName = "Kippling", EmailAddress = "lkippling5@wunderground.com", PhoneNumber = "9613037281", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"},
                new Client {FirstName = "Britt", LastName = "Itter", EmailAddress = "bitter6@cpanel.net", PhoneNumber = "8613623599", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"},
                new Client {FirstName = "Averil", LastName = "Rabb", EmailAddress = "arabb7@usda.gov", PhoneNumber = "7487355254", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"},
                new Client {FirstName = "Blondy", LastName = "Clutton", EmailAddress = "bclutton8@si.edu", PhoneNumber = "3469961229", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"},
                new Client {FirstName = "Jobye", LastName = "Hocking", EmailAddress = "jhocking9@discuz.net", PhoneNumber = "4331707313", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"},
                new Client {FirstName = "Clementius", LastName = "McCreedy", EmailAddress = "cmccreedya@soup.io", PhoneNumber = "3857470168", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"},
                new Client {FirstName = "Karalee", LastName = "Runcie", EmailAddress = "kruncieb@mozilla.com", PhoneNumber = "3823811166", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"},
                new Client {FirstName = "Georges", LastName = "Gittins", EmailAddress = "ggittinsc@blogger.com", PhoneNumber = "6264381477", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"},
                new Client {FirstName = "Donaugh", LastName = "Ber", EmailAddress = "dberd@posterous.com", PhoneNumber = "4444446197", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"},
                new Client {FirstName = "Abram", LastName = "Spitaro", EmailAddress = "aspitaroe@va.gov", PhoneNumber = "6609464653", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"},
                new Client {FirstName = "Mitch", LastName = "Montier", EmailAddress = "mmontierf@cdc.gov", PhoneNumber = "7922472972", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"},
                new Client {FirstName = "Marlow", LastName = "Chasemore", EmailAddress = "mchasemoreg@bloglines.com", PhoneNumber = "1089548485", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"},
                new Client {FirstName = "Tildy", LastName = "Lisett", EmailAddress = "tlisetth@dion.ne.jp", PhoneNumber = "7499554785", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"},
                new Client {FirstName = "Jessie", LastName = "Paulo", EmailAddress = "jpauloi@uol.com.br", PhoneNumber = "1701797835", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"},
                new Client {FirstName = "Jaquelyn", LastName = "Kaming", EmailAddress = "jkamingj@princeton.edu", PhoneNumber = "4175472486", CreatedBy = "fcf61c2b-880c-4b03-86ac-5c12dc63dbe2"}
            };
            foreach (Client cl in clients)
            {
                context.Clients.Add(cl);
            }
            context.SaveChanges();

            // Look for any AppColors
            if (context.AppColors.Any())
                return;   // DB has been seeded

            var colors = new AppColor[]
            {
                new AppColor { Name = "Light Blue", Abbreviation = "LBL" },
                new AppColor { Name = "Turquoise", Abbreviation = "TRQ" },
                new AppColor { Name = "Dark Blue", Abbreviation = "DBL" },
                new AppColor { Name = "Blue", Abbreviation = "BLU" },
                new AppColor { Name = "Amethyst", Abbreviation = "AME" },
                new AppColor { Name = "Purple", Abbreviation = "PLE" },
                new AppColor { Name = "Lavender", Abbreviation = "LAV" },
                new AppColor { Name = "Mauve", Abbreviation = "MVE" },
                new AppColor { Name = "Pink", Abbreviation = "PNK" },
                new AppColor { Name = "Red", Abbreviation = "RED" },
                new AppColor { Name = "Maroon", Abbreviation = "MAR" },
                new AppColor { Name = "Orange", Abbreviation = "ONG" },
                new AppColor { Name = "Copper", Abbreviation = "CPR" },
                new AppColor { Name = "Bronze", Abbreviation = "BRZ" },
                new AppColor { Name = "Tan", Abbreviation = "TAN" },
                new AppColor { Name = "Gold", Abbreviation = "GLD" },
                new AppColor { Name = "Yellow", Abbreviation = "YEL" },
                new AppColor { Name = "Light Green", Abbreviation = "LGR" },
                new AppColor { Name = "Green", Abbreviation = "GRN" },
                new AppColor { Name = "Dark Green", Abbreviation = "DGR" },
                new AppColor { Name = "Teal", Abbreviation = "TEA" },
                new AppColor { Name = "Brown", Abbreviation = "BRO" },
                new AppColor { Name = "Cream", Abbreviation = "BRM" },
                new AppColor { Name = "Beige", Abbreviation = "BGE" },
                new AppColor { Name = "Taupe", Abbreviation = "TPE" },
                new AppColor { Name = "Silver", Abbreviation = "SIL" },
                new AppColor { Name = "Chrome", Abbreviation = "COM" },
                new AppColor { Name = "Grey", Abbreviation = "GRY" },
                new AppColor { Name = "Black", Abbreviation = "BLK" },
                new AppColor { Name = "White", Abbreviation = "WHI" },
                new AppColor { Name = "Camouflage", Abbreviation = "CAM" },
                new AppColor { Name = "Multi-Colored", Abbreviation = "MUL COL" },
            };
            foreach (AppColor c in colors)
            {
                context.AppColors.Add(c);
            }
            context.SaveChanges();

            // Look for any Vehicles.
            if (context.Vehicles.Any())
                return;   // DB has been seeded

            var vehicles = new Vehicle[]
            {
                new Vehicle {Vin = "2T1BURHE2FC123119", Make = "Volkswagen", Model = "Jetta III", SubModel = "Frxpzsu", Year = 1993, Color = 12, Owner = 20},
                new Vehicle {  Vin = "WAUUL58E55A441045", Make = "Volvo", Model = "S80", SubModel = "Nlsdorz", Year = 2004, Color = 8, Owner = 20},
                new Vehicle {  Vin = "2D4RN7DG8BR790331", Make = "Chevrolet", Model = "Sportvan G20", SubModel = "Iaamdzt", Year = 1994, Color = 7, Owner = 6},
                new Vehicle {  Vin = "SCBCP73W79C252375", Make = "Ford", Model = "E150", SubModel = "Gupzjvp", Year = 1984, Color = 26, Owner = 5},
                new Vehicle {  Vin = "1GYFK63848R454259", Make = "GMC", Model = "Terrain", SubModel = "Ixgzpwk", Year = 2011, Color = 3, Owner = 9},
                new Vehicle {  Vin = "YV4902DZXD2545156", Make = "Ford", Model = "Explorer", SubModel = "Vvrzlip", Year = 1993, Color = 12, Owner = 3},
                new Vehicle {  Vin = "WAUKFAFL5CA391477", Make = "Oldsmobile", Model = "Silhouette", SubModel = "Jbrgddq", Year = 2001, Color = 7, Owner = 7},
                new Vehicle {  Vin = "3VW4A7AT9CM780076", Make = "Dodge", Model = "Ram 2500", SubModel = "Jzsczfo", Year = 2007, Color = 18, Owner = 18},
                new Vehicle {  Vin = "WVGAV7AX6BW100125", Make = "Toyota", Model = "Camry", SubModel = "Whzgkni", Year = 2012, Color = 8, Owner = 15},
                new Vehicle {  Vin = "1FADP5AU3FL860452", Make = "Saturn", Model = "L-Series", SubModel = "Pxdpqvm", Year = 2002, Color = 27, Owner = 7},
                new Vehicle {  Vin = "WP1AA2A24BL047347", Make = "BMW", Model = "M5", SubModel = "Jbfeibq", Year = 2002, Color = 9, Owner = 12},
                new Vehicle {  Vin = "WBA3B5C53FF202071", Make = "Volkswagen", Model = "Type 2", SubModel = "Dnjkssp", Year = 1986, Color = 10, Owner = 20},
                new Vehicle {  Vin = "JN8AS5MT5AW162872", Make = "Mercury", Model = "Tracer", SubModel = "Giedpjr", Year = 1993, Color = 17, Owner = 19},
                new Vehicle {  Vin = "19UUA8F3XEA461661", Make = "Lincoln", Model = "LS", SubModel = "Hslzkkw", Year = 2002, Color = 11, Owner = 3},
                new Vehicle {  Vin = "2G4WD582881352546", Make = "Ford", Model = "Econoline E150", SubModel = "Oypfkog", Year = 1993, Color = 23, Owner = 13},
                new Vehicle {  Vin = "4T1BD1EB6FU585998", Make = "Infiniti", Model = "J", SubModel = "Vyaiyxo", Year = 1996, Color = 25, Owner = 14},
                new Vehicle {  Vin = "ZFBCFABH7EZ202697", Make = "Mazda", Model = "MX-5", SubModel = "Ovlkkju", Year = 1996, Color = 30, Owner = 5},
                new Vehicle {  Vin = "WAUJT58E44A705695", Make = "Volkswagen", Model = "Golf", SubModel = "Djddvnw", Year = 2000, Color = 32, Owner = 9},
                new Vehicle {  Vin = "5N1AT2ML4FC524427", Make = "Chevrolet", Model = "Colorado", SubModel = "Lwsdncb", Year = 2011, Color = 4, Owner = 16},
                new Vehicle {  Vin = "VNKJTUD34FA306734", Make = "Buick", Model = "Skyhawk", SubModel = "Vkbtqpe", Year = 1986, Color = 29, Owner = 19},
                new Vehicle {  Vin = "19VDE1F51FE615287", Make = "Ford", Model = "Ranger", SubModel = "Gvfxfga", Year = 2006, Color = 3, Owner = 19},
                new Vehicle {  Vin = "JH4DC23131S226160", Make = "Chrysler", Model = "New Yorker", SubModel = "Tlnafcj", Year = 1993, Color = 25, Owner = 17},
                new Vehicle {  Vin = "1FTEW1CF9FK710776", Make = "Dodge", Model = "Ram 2500", SubModel = "Acxmypk", Year = 2009, Color = 21, Owner = 5},
                new Vehicle {  Vin = "5N1AT2ML0FC603206", Make = "GMC", Model = "Yukon XL 2500", SubModel = "Bfumblf", Year = 2013, Color = 5, Owner = 14},
                new Vehicle {  Vin = "1GTN1UEH5FZ730273", Make = "Ferrari", Model = "458 Italia", SubModel = "Xlzzcwy", Year = 2011, Color = 9, Owner = 12},
                new Vehicle {  Vin = "WA1VMAFEXCD854990", Make = "Audi", Model = "A7", SubModel = "Lmnlwpg", Year = 2012, Color = 23, Owner = 7},
                new Vehicle {  Vin = "5UXZW0C53BL931864", Make = "Toyota", Model = "Camry", SubModel = "Ncuyuld", Year = 1993, Color = 28, Owner = 11},
                new Vehicle {  Vin = "YV440MBC7F1486175", Make = "Ford", Model = "Bronco", SubModel = "Cjbswhc", Year = 1985, Color = 16, Owner = 20},
                new Vehicle {  Vin = "WAUBF98E17A338486", Make = "Ram", Model = "C/V", SubModel = "Bsrepas", Year = 2012, Color = 24, Owner = 7},
                new Vehicle {  Vin = "3N1AB6AP9CL413588", Make = "Mazda", Model = "Mazdaspeed6", SubModel = "Pqujsjp", Year = 2007, Color = 10, Owner = 15},
                new Vehicle {  Vin = "1N4AL3AP0DC081682", Make = "Mercedes-Benz", Model = "C-Class", SubModel = "Sskvyzg", Year = 2011, Color = 7, Owner = 7},
                new Vehicle {  Vin = "JN1AZ4EH8DM636439", Make = "Lexus", Model = "IS", SubModel = "Ivtxbux", Year = 2002, Color = 23, Owner = 6},
                new Vehicle {  Vin = "WAUDH78EX7A226017", Make = "Audi", Model = "S8", SubModel = "Uatmlbi", Year = 2002, Color = 2, Owner = 4},
                new Vehicle {  Vin = "WAUCFAFHXBN242280", Make = "Mercedes-Benz", Model = "R-Class", SubModel = "Zlfqkqu", Year = 2008, Color = 26, Owner = 11},
                new Vehicle {  Vin = "1N6AF0KY6FN855770", Make = "Toyota", Model = "Camry", SubModel = "Erbqggm", Year = 2009, Color = 21, Owner = 17},
                new Vehicle {  Vin = "WAULFAFH2AN211281", Make = "GMC", Model = "Yukon XL 1500", SubModel = "Yecuttz", Year = 2006, Color = 6, Owner = 1},
                new Vehicle {  Vin = "JN8AF5MR4DT577485", Make = "Audi", Model = "S6", SubModel = "Istgxwy", Year = 2009, Color = 19, Owner = 19},
                new Vehicle {  Vin = "3C3CFFER7FT650160", Make = "Subaru", Model = "Outback", SubModel = "Pnnxlme", Year = 2008, Color = 30, Owner = 15},
                new Vehicle {  Vin = "3VW467AT2CM832648", Make = "Acura", Model = "CL", SubModel = "Xtnudnd", Year = 2002, Color = 11, Owner = 8},
                new Vehicle {  Vin = "5UXFG2C50E0770536", Make = "Mercedes-Benz", Model = "500SEC", SubModel = "Kxecfas", Year = 1993, Color = 15, Owner = 15},
                new Vehicle {  Vin = "2G61S5S39D9172500", Make = "Audi", Model = "5000CS", SubModel = "Ofdbcsm", Year = 1987, Color = 29, Owner = 7},
                new Vehicle {  Vin = "JN1AZ4EH3BM134953", Make = "Volkswagen", Model = "Type 2", SubModel = "Fsuwzlv", Year = 1991, Color = 16, Owner = 9},
                new Vehicle {  Vin = "1GTC5MF91B8716308", Make = "Scion", Model = "xB", SubModel = "Ieyqikt", Year = 2008, Color = 14, Owner = 8},
                new Vehicle {  Vin = "JN8AF5MR9ET173910", Make = "Lexus", Model = "LX", SubModel = "Jnkrqaj", Year = 2006, Color = 17, Owner = 12},
                new Vehicle {  Vin = "SALVP2BG9FH550582", Make = "Mitsubishi", Model = "Galant", SubModel = "Psvdfio", Year = 2009, Color = 19, Owner = 18},
                new Vehicle {  Vin = "WA1DGBFE4BD822981", Make = "BMW", Model = "3 Series", SubModel = "Inhztef", Year = 2000, Color = 26, Owner = 15},
                new Vehicle {  Vin = "1G6DG8EG7A0064168", Make = "Kia", Model = "Amanti", SubModel = "Riobkmd", Year = 2006, Color = 3, Owner = 17},
                new Vehicle {  Vin = "1FTSW3A55AE826167", Make = "Mitsubishi", Model = "Endeavor", SubModel = "Yqtyajf", Year = 2005, Color = 13, Owner = 7},
                new Vehicle {  Vin = "WAUFEBFM6CA930885", Make = "Porsche", Model = "911", SubModel = "Nkwqyzt", Year = 2010, Color = 5, Owner = 3},
                new Vehicle {  Vin = "3C4PDCEG7ET651663", Make = "Corbin", Model = "Sparrow", SubModel = "Mbyqxmh", Year = 1999, Color = 22, Owner = 11},
                new Vehicle {  Vin = "JHMFA3F26AS585298", Make = "Dodge", Model = "Ram 50", SubModel = "Xirktze", Year = 1992, Color = 22, Owner = 14},
                new Vehicle {  Vin = "JH4DC54894S138389", Make = "Mercedes-Benz", Model = "SLK-Class", SubModel = "Evyfhiq", Year = 2006, Color = 30, Owner = 11},
                new Vehicle {  Vin = "KMHFC4DF4BA257047", Make = "Ford", Model = "Explorer", SubModel = "Fqypawj", Year = 1997, Color = 20, Owner = 16},
                new Vehicle {  Vin = "1C4RDJDG3DC186159", Make = "Honda", Model = "Accord", SubModel = "Uqsibik", Year = 2000, Color = 13, Owner = 10},
                new Vehicle {  Vin = "1C4PJLAK0CW864643", Make = "BMW", Model = "M5", SubModel = "Blxmris", Year = 2008, Color = 27, Owner = 17},
                new Vehicle {  Vin = "JTHFE2C20E2166419", Make = "GMC", Model = "Suburban 2500", SubModel = "Swlanky", Year = 1993, Color = 4, Owner = 4},
                new Vehicle {  Vin = "1G6AS5S39F0989155", Make = "Hyundai", Model = "Genesis Coupe", SubModel = "Omloyxb", Year = 2013, Color = 15, Owner = 16},
                new Vehicle {  Vin = "5J6TF2H50DL916652", Make = "Ford", Model = "Ranger", SubModel = "Rkeocfd", Year = 2010, Color = 16, Owner = 12},
                new Vehicle {  Vin = "4T3BA3BB0AU598982", Make = "Audi", Model = "S6", SubModel = "Bppwxgh", Year = 2003, Color = 12, Owner = 15},
                new Vehicle {  Vin = "JN1CV6EK1EM800563", Make = "Jeep", Model = "Liberty", SubModel = "Oiwjykq", Year = 2006, Color = 22, Owner = 15},
                new Vehicle {  Vin = "3VW467AT5CM581642", Make = "Mitsubishi", Model = "Starion", SubModel = "Ikbnapj", Year = 1989, Color = 31, Owner = 11},
                new Vehicle {  Vin = "WVWED7AJ7CW736333", Make = "Mercedes-Benz", Model = "E-Class", SubModel = "Bkfjsgx", Year = 1996, Color = 4, Owner = 20},
                new Vehicle {  Vin = "WAUJC58E63A158783", Make = "Kia", Model = "Optima", SubModel = "Ksabqab", Year = 2006, Color = 9, Owner = 15},
                new Vehicle {  Vin = "WBAVL1C50DV405582", Make = "Toyota", Model = "Tacoma", SubModel = "Ugkvqnw", Year = 1995, Color = 16, Owner = 20},
                new Vehicle {  Vin = "5N1AN0NU4EN556738", Make = "GMC", Model = "Safari", SubModel = "Svarwtv", Year = 2003, Color = 32, Owner = 6},
                new Vehicle {  Vin = "JTMHY7AJ4F4138119", Make = "Kia", Model = "Rondo", SubModel = "Tdshhzr", Year = 2010, Color = 10, Owner = 8},
                new Vehicle {  Vin = "19VDE1F55DE141728", Make = "Chrysler", Model = "300", SubModel = "Vmlpldh", Year = 2009, Color = 24, Owner = 2},
                new Vehicle {  Vin = "1FBNE3BL7BD949154", Make = "Mitsubishi", Model = "Galant", SubModel = "Pzrhjfr", Year = 1987, Color = 25, Owner = 4},
                new Vehicle {  Vin = "1N6BF0KM8FN915663", Make = "Mitsubishi", Model = "Montero Sport", SubModel = "Lmynere", Year = 2002, Color = 11, Owner = 4},
                new Vehicle {  Vin = "JTEBU5JR4F5447283", Make = "Mercedes-Benz", Model = "G-Class", SubModel = "Dbcbglt", Year = 2011, Color = 1, Owner = 2},
                new Vehicle {  Vin = "WAUML44D43N125004", Make = "Honda", Model = "Prelude", SubModel = "Tjsfyok", Year = 1999, Color = 1, Owner = 8},
                new Vehicle {  Vin = "WAUEF78E86A074909", Make = "Mercedes-Benz", Model = "CL-Class", SubModel = "Vpryyww", Year = 2001, Color = 25, Owner = 8},
                new Vehicle {  Vin = "JN1AJ0HP7BM965097", Make = "Dodge", Model = "Ram 3500", SubModel = "Vrnaeom", Year = 2006, Color = 32, Owner = 10},
                new Vehicle {  Vin = "TRUXD38J391690048", Make = "Chevrolet", Model = "Uplander", SubModel = "Mlciwff", Year = 2007, Color = 23, Owner = 15},
                new Vehicle {  Vin = "1GYUCBEF2AR687491", Make = "Lotus", Model = "Exige", SubModel = "Sdfctup", Year = 2005, Color = 17, Owner = 1},
                new Vehicle {  Vin = "WAUFFAFL1EN432720", Make = "Buick", Model = "Lucerne", SubModel = "Czruahn", Year = 2011, Color = 30, Owner = 10},
                new Vehicle {  Vin = "1D7RE3GK4AS565980", Make = "GMC", Model = "Vandura 1500", SubModel = "Bzitgmd", Year = 1993, Color = 18, Owner = 14},
                new Vehicle {  Vin = "5UMDU93568L946501", Make = "Rolls-Royce", Model = "Phantom", SubModel = "Zxsttuy", Year = 2008, Color = 21, Owner = 11},
                new Vehicle {  Vin = "3D7JB1EPXAG490413", Make = "Volvo", Model = "S40", SubModel = "Iuoujfa", Year = 2010, Color = 4, Owner = 17},
                new Vehicle {  Vin = "JN8AE2KP0F9327888", Make = "Mitsubishi", Model = "Starion", SubModel = "Vpcnqvx", Year = 1986, Color = 29, Owner = 9},
                new Vehicle {  Vin = "2HNYD18603H518691", Make = "Bentley", Model = "Continental Super", SubModel = "Vtxbxon", Year = 2010, Color = 15, Owner = 11},
                new Vehicle {  Vin = "1G6DH577480650457", Make = "Ford", Model = "E-Series", SubModel = "Tnpwcbu", Year = 1989, Color = 18, Owner = 1},
                new Vehicle {  Vin = "2C3CDZBG2FH365465", Make = "Infiniti", Model = "FX", SubModel = "Oiucplp", Year = 2004, Color = 17, Owner = 17},
                new Vehicle {  Vin = "JA4AP3AU5BZ607622", Make = "Kia", Model = "Rondo", SubModel = "Jlifnun", Year = 2009, Color = 9, Owner = 14},
                new Vehicle {  Vin = "1G6DE8EG6A0815279", Make = "Ford", Model = "F-Series", SubModel = "Bznyddx", Year = 1994, Color = 14, Owner = 15},
                new Vehicle {  Vin = "JTDJTUD36DD888887", Make = "GMC", Model = "Acadia", SubModel = "Dtwbzbq", Year = 2012, Color = 5, Owner = 4},
                new Vehicle {  Vin = "WVWED7AJ4AW331527", Make = "Ford", Model = "Crown Victoria", SubModel = "Gfzzkfk", Year = 2005, Color = 1, Owner = 20},
                new Vehicle {  Vin = "TRUWX28N021357389", Make = "Lincoln", Model = "Town Car", SubModel = "Uimuret", Year = 2010, Color = 2, Owner = 3},
                new Vehicle {  Vin = "JH4KA965X4C499521", Make = "Mercedes-Benz", Model = "G-Class", SubModel = "Jlkkfvz", Year = 2011, Color = 12, Owner = 18},
                new Vehicle {  Vin = "5FRYD3H61EB155410", Make = "Isuzu", Model = "Space", SubModel = "Ikowskq", Year = 1992, Color = 14, Owner = 3},
                new Vehicle {  Vin = "4T1BK3DB4BU584202", Make = "Ford", Model = "Probe", SubModel = "Vcbomoh", Year = 1993, Color = 4, Owner = 18},
                new Vehicle {  Vin = "3N1CE2CP1FL587990", Make = "Mercedes-Benz", Model = "G-Class", SubModel = "Hcbbitr", Year = 2005, Color = 5, Owner = 14},
                new Vehicle {  Vin = "5NPET4AC8AH687875", Make = "Ford", Model = "Ranger", SubModel = "Nylbgjm", Year = 2003, Color = 2, Owner = 20},
                new Vehicle {  Vin = "JH4CU4F48CC945802", Make = "Mitsubishi", Model = "Galant", SubModel = "Wmxjaem", Year = 1994, Color = 19, Owner = 9},
                new Vehicle {  Vin = "3D7TT2CT2AG135912", Make = "Hyundai", Model = "Sonata", SubModel = "Uxwxzlm", Year = 1997, Color = 12, Owner = 6},
                new Vehicle {  Vin = "W04G05GV0B1016025", Make = "Saturn", Model = "Outlook", SubModel = "Wwztaoa", Year = 2009, Color = 3, Owner = 13},
                new Vehicle {  Vin = "JTHBE1BL2F1522041", Make = "Mazda", Model = "MX-5", SubModel = "Ssdkaxy", Year = 1995, Color = 10, Owner = 2},
                new Vehicle {  Vin = "WBA3B5G52DN626385", Make = "Mitsubishi", Model = "Diamante", SubModel = "Smtjnao", Year = 1997, Color = 32, Owner = 9},
                new Vehicle {  Vin = "KL4CJASB0EB110521", Make = "Mazda", Model = "Miata MX-5", SubModel = "Eshzsfj", Year = 2007, Color = 9, Owner = 8},
                new Vehicle {  Vin = "KNDJT2A27D7229554", Make = "Mercedes-Benz", Model = "GL-Class", SubModel = "Jbunrtw", Year = 2011, Color = 30, Owner = 8}
            };
            foreach (Vehicle v in vehicles)
            {
                context.Vehicles.Add(v);
            }
            context.SaveChanges();            
        }
    }
}
