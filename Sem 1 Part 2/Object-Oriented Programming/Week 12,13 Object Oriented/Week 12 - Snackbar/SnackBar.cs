using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_12___Snackbar
{
    public class SnackBar
    {
        public SnackBar(Snack snackOne, Snack snackTwo, Snack snackThree)
        {
            Snacks = new List<Snack>
            {
                snackOne,
                snackTwo, 
                snackThree
            };
        }
        public List<Snack> Snacks { get; set; }
        public double Revenue { get; set; }
        public double ProcessOrder(int snack1, int snack2, int snack3)
        {
            if (!Snacks[0].DecreaseStock(snack1))
            {
                return -1;
            }
            if (!Snacks[1].DecreaseStock(snack2))
            {
                return -2;
            }
            if (!Snacks[2].DecreaseStock(snack3))
            {
                return -3;
            }
            Revenue += (Snacks[0].Price * snack1) + (Snacks[1].Price * snack2) + (Snacks[2].Price * snack3);
            return (Snacks[0].Price * snack1) + (Snacks[1].Price * snack2) + (Snacks[2].Price * snack3);
        }
        public double GetRevenue()
        {
            return Revenue;
        }
        public void AddSnack(Snack snack)
        {
            Snacks.Add(snack);
        }
        public void RemoveSnack(Snack snack)
        {
            Snacks.Remove(snack);
        }
        public void EditSnack(Snack snack, double price, int stock)
        {
            snack.Price = price;
            snack.InStockAmount= stock;
        }
    }
}
