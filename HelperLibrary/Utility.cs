
namespace HelperLibrary
{
    public class Utility
    {
        /// <summary>
        /// Method that check if the value is inside the range or not, the range is limited with a minimum and the maximum values (each included).
        /// </summary>
        /// <param name="value">The value that we want to check.</param>
        /// <param name="min">The lowest value in the range.</param>
        /// <param name="max">The highest value in the range.</param>
        /// <returns>Returns TRUE if is inside the MIN and the MAX values, and FALSE if not. </returns>
        public static bool CheckIntInput(int value, int min, int max)
        {
            return value >= min && value <= max;
        }

        /// <summary>
        /// Method that ask a user for an integer value, if the value is outside the range the method will ask for a new one, until the value is inside.
        /// </summary>
        /// <param name="errorMessage">A message that will print in the console if the user enters a outrange values.</param>
        /// <param name="min">The lowest value in the range.</param>
        /// <param name="max">The highest value in the range.</param>
        /// <returns>Returns a integer value which is inside the range. </returns>
        public static int ValidateInput(string errorMessage, int min, int max)
        {
            int input;
            do
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (!CheckIntInput(input, min, max))
                {
                    Console.WriteLine(errorMessage);
                }
            } while (!CheckIntInput(input, min, max));

            return input;
        }

        /// <summary>
        /// Method that returns a string with the current date.
        /// </summary>
        /// <returns> A String with the current date in a "dd/MM/yyyy" format.</returns>
        public static string RegisterDate()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Method that returns a random value between 1 and 99.
        /// </summary>
        /// <returns> A integer value between 1 and 99, which will represent the affection grade </returns>
        public static int RandomAffectationGrade()
        {
            Random random = new();
            return random.Next(1,100);
        }

    }
}
