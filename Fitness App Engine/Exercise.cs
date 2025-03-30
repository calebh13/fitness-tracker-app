using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_App_Engine
{
    public class Exercise
    {
        private string name;
        private int weight;
        private int sets;
        private int reps;

        public string Name { get => name; }
        public int Weight { get => weight; }
        public int Sets { get => sets; }
        public int Reps { get => reps; }

        public Exercise(string name, int weight, int sets, int reps)
        {
            this.name = name;
            this.weight = weight;
            this.sets = sets;
            this.reps = reps;
        }
    }
}
