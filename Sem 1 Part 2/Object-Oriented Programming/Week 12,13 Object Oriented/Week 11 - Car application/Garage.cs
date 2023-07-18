using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_11___Car_application
{
    public class Garage
    {
        public Garage()
        {
            Cars = new List<Car>();
        }
        public List<Car> Cars { get; set; }

        public void AddCar(Car car) 
        {
            Cars.Add(car);
        }
        public void RemoveCar(Car car) 
        { 
            Cars.Remove(car);
        }
    }
}
