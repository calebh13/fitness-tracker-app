using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Fitness_App_Engine
{
    public class calendarBackend
    {
        Dictionary<DateTime, daysBackend> days;
        public List<Exercise> goals { get; set; }
        //List<goals> goals
        public calendarBackend()
        {
            days = new Dictionary<DateTime, daysBackend>();
            this.goals = new List<Exercise>();
        }

        public Dictionary<DateTime, daysBackend> Days { get => this.days; set => this.days = value; }
        
        public daysBackend getDay(DateTime date)
        {
            if(this.days.ContainsKey(date))
            {
                return this.days[date];
            }
            else
            {
                return new daysBackend();
            }
        }

        public bool dateIsInDictionary(DateTime date)
        {
            if(days.ContainsKey(date))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddGoals(List<Exercise> newExercises)
        {
            foreach (Exercise e in newExercises){
                goals.Add(e);
            }
        }
        public void addWorkouts(DateTime date, List<Exercise> newExercises)
        {
            if(dateIsInDictionary(date))
            {
                days[date].addExercises(newExercises);
            }
            else
            {
                days.Add(date, new daysBackend(newExercises));
            }
        }


        public void addMeals(DateTime date, List<Meal> newMeals)
        {
            if (dateIsInDictionary(date))
            {
                days[date].addNutrition(newMeals);
            }
            else
            {
                days.Add(date, new daysBackend(newMeals));
            }
        }
        /*
        private void addDay(DateTime date, List<nutrition> newNutrition)
        {
            daysBackend newDay = new daysBackend();
            newDay.nutritions = newNutrition;
            days.Add(date, newDay);
        }
        private void addDay(DateTime date, List<exercises> newExercises)
        {
            daysBackend newDay = new daysBackend();
            newDay.exercises = newExercises;
            days.Add(date, newDay);
        }
        */
        //private void updateDay 
    }
}
