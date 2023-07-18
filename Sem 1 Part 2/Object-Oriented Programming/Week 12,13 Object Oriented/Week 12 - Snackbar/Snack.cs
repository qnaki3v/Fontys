using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_12___Snackbar
{
    public class Snack
    {
        public Snack(string name, double price, int amount)
        {
            Name = name;
            Price = price;
            InStockAmount = amount;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InStockAmount { get; set; }

        public bool DecreaseStock(int amount)
        {
            if (InStockAmount - amount >= 0)
            {
                InStockAmount-= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetName()
        {
            return Name;
        }
        public string GetPrice()
        {
            return Price.ToString();
        }
        public string GetAmountInStock()
        {
            return InStockAmount.ToString();
        }
        public override string ToString()
        {
            return $"{Name}, Count: {InStockAmount}, Price: {Price:f2}€";
        }
    }
}
