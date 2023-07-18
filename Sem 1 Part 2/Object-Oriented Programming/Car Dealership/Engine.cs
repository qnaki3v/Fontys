using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership
{
    public class Engine
    {
        private int horsePower;
        private int newtonMeters;
        private int capacity;

        public Engine(int horsePower, int newtonMeters, int capacity)
        {
            this.horsePower = horsePower;
            this.newtonMeters = newtonMeters;
            this.capacity = capacity;
        }
    }
}
