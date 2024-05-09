using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_dot_net.BeverageInterface
{
    public class Latte : IBeverage
    {
        private readonly string _size;
        public Latte(string size)
        {
            _size = size;
        }
        public string GetName()
        {
            return "Latte";
        }

        public void ChooseCup()
        {
            switch (_size)
            {
                case "Small":
                    Console.WriteLine("The barista chose a small cup");
                    break;
                case "Medium":
                    Console.WriteLine("The barista chose a medium cup");
                    break;
                case "Large":
                    Console.WriteLine("The barista chose a large cup");
                    break;
                default:
                    Console.WriteLine("Error, this size does not exist");
                    throw new ArgumentException("Error, this size does not exist");
            }
        }

        public void AddIngredients()
        {
            Console.WriteLine("Adding espresso and steamed milk.");
        }

        public void PourLiquid()
        {
            Console.WriteLine("Pouring latte into the cup.");
        }
    }
}
