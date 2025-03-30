namespace Fitness_App_Engine
{
    public class Meal
    {
        public string Name { get; }
        public int Calories { get; }
        public int Protein { get; }

        public Meal(string name, int calories, int protein)
        {
            this.Name = name;
            this.Calories = calories;
            this.Protein = protein;
        }

    }
}
