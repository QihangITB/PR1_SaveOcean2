
namespace ObjectLibrary
{
    public class Rescue
    {
        private const string DefaultLocation = "Barcelona";
        public string? Code { get; set; }
        public string? Date { get; set; }
        public Animal? Family { get; set; }
        public int AffectationGrade { get; set; }
        public string? Location { get; set; }

        public Rescue(string code, string date, Animal family, int affectationGrade, string location)
        {
            Code = code;
            Date = date;
            Family = family;
            AffectationGrade = affectationGrade;
            Location = location;
        }

        public Rescue(Animal animal) : this(GenerateCode(), RegisterDate(), animal, RandomAffectationGrade(), DefaultLocation) { }


        /// <summary>
        /// Method that returns a code which is a string with the next format ("RES" + a random number between 0 and 999 with 3 digits).
        /// </summary>
        /// <returns> A String which contains "RES" + number of 3 digits  between 0 and 999. </returns>
        private static string GenerateCode()
        {
            Random random = new();
            string code = "RES" + random.Next(1000).ToString("000");

            return code;
        }

        /// <summary>
        /// Method that returns a string with the current date.
        /// </summary>
        /// <returns> A String with the current date in a "dd/MM/yyyy" format.</returns>
        private static string RegisterDate()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Method that returns a random value between 1 and 99.
        /// </summary>
        /// <returns> A integer value between 1 and 99, which will represent the affection grade </returns>
        private static int RandomAffectationGrade()
        {
            Random random = new();
            return random.Next(1, 100);
        }

        /// <summary>
        /// Method to get the document of the rescue, with all the information about it.
        /// </summary>
        /// <returns>A String with all the information in a table format. </returns>
        public string GetDocument() => 
            $"+-------------------------------------------------------------+\r\n" +
            $"|                           RESCUE                            |\r\n" +
            $"+-------------------------------------------------------------+\r\n" +
            $"| # Rescue | Rescue Date | Super Family      | AG | Location  |\r\n" +
            $"+-------------------------------------------------------------+\r\n" +
            $"| {Code}   | {Date}  | {Family}        | {AffectationGrade} | {Location} |\r\n" +
            $"+-------------------------------------------------------------+";
        

    }
}

