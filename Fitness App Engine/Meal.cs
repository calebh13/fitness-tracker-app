using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_App_Engine
{
    class Meal
    {
        private string food;
        private int calories;
        private int protein;

        public string Food {  get { return food; } set { food = value; } }
        public int Protein { get { return protein; } set { protein = value; } }
        private int Calories { get { return calories; } set { calories = value; } }
        
        public Meal(string food, int calories, int protein)
        {
            this.food = food;
            this.calories = calories;
            this.protein = protein;
        }
    }
}
