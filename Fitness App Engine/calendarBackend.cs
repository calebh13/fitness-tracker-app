using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_App_Engine
{
    public class calendarBackend
    {
        Dictionary<DateTime, daysBackend> days;
        //List<goals> goals
        public calendarBackend()
        {
            days = new Dictionary<DateTime, daysBackend>();
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
