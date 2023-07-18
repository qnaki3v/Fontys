using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership
{
    public class Car
    {
        private decimal price;
        private string brand;
        private string model;
        private Engine engine; 
        private Color color;
        private string type;

        public Car(decimal price, string brand, string model, Engine engine, Color color, string type)
        {
            this.price = price;
            this.brand = brand;
            this.model = model;
            this.engine = engine;
            this.color = color;
            this.type = type;
        }
    }
}
