using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_App_Engine
{
    public class daysBackend
    {
        private List<Exercise> exercises;
        private List<Meal> nutrition;

        public List<Exercise> Exercises { get => this.exercises; }
        public List<Meal> Nutrition { get => this.nutrition; }

        public daysBackend()
        {
            this.exercises = new List<Exercise>();
            this.nutrition = new List<Meal>();
        }


        public daysBackend(List<Exercise> exercises, List<Meal> nutrition)
        {
            this.exercises = new List<Exercise>(exercises);
            this.nutrition = new List<Meal>(nutrition);
        }

        public daysBackend(List<Exercise> exercises)
        {
            this.exercises = new List<Exercise>(exercises);
            this.nutrition = new List<Meal>();
        }

        public daysBackend(List<Meal> nutrition)
        {
            this.exercises = new List<Exercise>();
            this.nutrition = new List<Meal>(nutrition) ;
        }

        public List<Exercise> GetExercises()
        {
            return this.exercises;
        }

        public List<Meal> GetMeals()
        {
            return this.nutrition;
        }

        public void addExercises(List<Exercise> newExercises)
        {
            this.exercises.AddRange(newExercises);
        }
        public void addNutrition(List<Meal> newMeals)
        {
            this.nutrition.AddRange(newMeals);
        }

        public void clearExercises()
        {
            this.exercises.Clear();
        }

        public void clearNutrition()
        {
            this.nutrition.Clear();
        }
    }
}
