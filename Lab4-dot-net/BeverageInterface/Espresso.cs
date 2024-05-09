using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_dot_net.BeverageInterface
{
    public class Espresso : IBeverage
    {
        private readonly string _size;
        public Espresso(string size)
        {
            _size = size;
        }
        public string GetName()
        {
            return "Espresso";
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
            Console.WriteLine("Grinding coffee beans.");
            Console.WriteLine("Preparing espresso shot.");
        }

        public void PourLiquid()
        {
            Console.WriteLine("Pouring espresso into the cup.");
        }
    }
}
