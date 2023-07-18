using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_11___Car_application
{
    public class Car
    {
        public Car(string brand, int accelerationAndBreaking, int maxSpeed)
        {
            Brand = brand;
            CurrSpeed = 0;
            AccelerationAndBreaking = accelerationAndBreaking;
            MaxSpeed = maxSpeed;
        }
        public string Brand { get; set; }
        public int CurrSpeed { get; set; }
        public int AccelerationAndBreaking { get; set; }
        public int MaxSpeed { get; set; }

        public string Accelerate()
        {
            if (CurrSpeed + AccelerationAndBreaking > MaxSpeed)
            {
                return "Cannot accelerate over the max speed";
            }
            else
            {
                CurrSpeed += AccelerationAndBreaking;
                return $"Accelerated. Now speed is {CurrSpeed}";
            }
        }
        public string UseBreaks()
        {
            if (CurrSpeed - AccelerationAndBreaking < 0)
            {
                return "Cannot decelerate below 0";
            }
            else
            {
                CurrSpeed -= AccelerationAndBreaking;
                return $"Used breaks. Now speed is {CurrSpeed}";
            }
        }
        public string SpeedNow()
        {
            return $"Speed of my {Brand} is {CurrSpeed} and its maximum speed is {MaxSpeed}km/h";
        }
        public override string ToString()
        {
            return Brand;
        }
    }
}
