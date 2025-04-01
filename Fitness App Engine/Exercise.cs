using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_App_Engine
{
    public class Exercise
    {
        public string Name { get; }
        public int Weight { get; }
        public int Sets { get; }
        public int Reps { get; }

        public Exercise(string name, int weight, int sets, int reps)
        {
            this.Name = name;
            this.Weight = weight;
            this.Sets = sets;
            this.Reps = reps;
        }
    }
}
