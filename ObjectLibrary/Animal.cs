
namespace ObjectLibrary
{
    public class Animal
    {
        private const int DefaultIntValue = 0;
        private const string DefaultStringValue = "";

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? SuperFamily { get; set; }
        public string? Species { get; set; }
        public float Weight { get; set; }

        public Animal(int id, string name, string superFamily, string species, float weight)
        {
            Id = id;
            Name = name;
            SuperFamily = superFamily;
            Species = species;
            Weight = weight;
        }

        public Animal(string name, string superFamily, string species, float weight) : this(DefaultIntValue, name, superFamily, species, weight) { }

        public Animal() : this(DefaultStringValue, DefaultStringValue, DefaultStringValue, DefaultIntValue) { }

        public override string ToString()
        {
            return $"{SuperFamily}";
        }

        /// <summary>
        /// Method that calculates the affectation grade of the Sea Turtle after the application of a treatment.
        /// </summary>
        /// <param name="affectation">The level of affectation that have the animal at the beginning.</param>
        /// <param name="healOption">The option that the user has chosen. (1) Heal (2) Move to a medical center</param>
        /// <returns>The final value of the affectation grade in a integer value. </returns>
        public int SeaTurtleTreatment(int affectation, int healOption)
        {
            int value = healOption == 1 ? 15 : 15;
            return (int) (2 * affectation + 3) - ((affectation - 20) * 2) - value;
        }

        /// <summary>
        /// Method that calculates the affectation grade of the Sea Birds after the application of a treatment.
        /// </summary>
        /// <param name="affectation">The level of affectation that have the animal at the beginning.</param>
        /// <param name="healOption">The option that the user has chosen. (1) Heal (2) Move to a medical center</param>
        /// <returns>The final value of the affectation grade in a integer value. </returns>
        public int SeaBirdTreatment(int affectation, int healOption)
        {
            int value = healOption == 1 ? 5 : 0;
            return (int) (affectation - value) / 5;
        }

        /// <summary>
        /// Method that calculates the affectation grade of the Cetacean after the application of a treatment.
        /// </summary>
        /// <param name="affectation">The level of affectation that have the animal at the beginning.</param>
        /// <param name="healOption">The option that the user has chosen. (1) Heal (2) Move to a medical center</param>
        /// <returns>The final value of the affectation grade in a integer value. </returns>
        public int CetaceanTreatment(int affectation, int healOption)
        {
            int value = healOption == 1 ? 50 : 0;
            return (int) affectation - (affectation / 5) - value;
        }

    }
}
