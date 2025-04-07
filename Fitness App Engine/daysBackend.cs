using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_App_Engine
{
    public class daysBackend
    {
        public List<Exercise> Exercises { get; set; }
        public List<Meal> Nutrition { get; set; }

        public daysBackend()
        {
            this.Exercises = new List<Exercise>();
            this.Nutrition = new List<Meal>();
        }


        public daysBackend(List<Exercise> exercises, List<Meal> nutrition)
        {
            this.Exercises = new List<Exercise>(exercises);
            this.Nutrition = new List<Meal>(nutrition);
        }

        public daysBackend(List<Exercise> exercises)
        {
            this.Exercises = new List<Exercise>(exercises);
            this.Nutrition = new List<Meal>();
        }

        public daysBackend(List<Meal> nutrition)
        {
            this.Exercises = new List<Exercise>();
            this.Nutrition = new List<Meal>(nutrition) ;
        }

        public List<Exercise> GetExercises()
        {
            return this.Exercises;
        }

        public List<Meal> GetMeals()
        {
            return this.Nutrition;
        }

        public void addExercises(List<Exercise> newExercises)
        {
            this.Exercises.AddRange(newExercises);
        }
        public void addNutrition(List<Meal> newMeals)
        {
            this.Nutrition.AddRange(newMeals);
        }

        public void clearExercises()
        {
            this.Exercises.Clear();
        }

        public void clearNutrition()
        {
            this.Nutrition.Clear();
        }
    }
}
