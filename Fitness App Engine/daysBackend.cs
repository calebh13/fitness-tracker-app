using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_App_Engine
{
    public class daysBackend
    {
        List<Exercise> exercies;
        List<Meal> nutrition;

        public daysBackend()
        {
            this.exercies = new List<Exercise>();
            this.nutrition = new List<Meal>();
        }


        public daysBackend(List<Exercise> exercies, List<Meal> nutrition)
        {
            this.exercies = exercies;
            this.nutrition = nutrition;
        }

        public daysBackend(List<Exercise> exercies)
        {
            this.exercies = exercies;
            this.nutrition = new List<Meal>();
        }

        public daysBackend(List<Meal> nutrition)
        {
            this.exercies = new List<Exercise>();
            this.nutrition = nutrition;
        }

        public List<Exercise> GetExercises()
        {
            return this.exercies;
        }

        public List<Meal> GetMeals()
        {
            return this.nutrition;
        }

        public void addExercises(List<Exercise> newExercises)
        {
            this.exercies.AddRange(newExercises);
        }
        public void addNutrition(List<Meal> newMeals)
        {
            this.nutrition.AddRange(newMeals);
        }

        public void clearExercises()
        {
            this.exercies.Clear();
        }

        public void clearNutrition()
        {
            this.nutrition.Clear();
        }
    }
}
