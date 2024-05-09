using Lab4_dot_net.BeverageFactoryInterface;
using Lab4_dot_net.BeverageInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_dot_net
{
    public class Barista
    {
        private IBeverageFactory _factory;
        public Barista(IBeverageFactory factory)
        {
            _factory = factory;
        }
        public void PrepareBeverage(string size)
        {
            IBeverage beverage = _factory.CreateBeverage(size);
            Console.WriteLine($"Preparing {beverage.GetName()}:");
            beverage.ChooseCup();
            beverage.AddIngredients();
            beverage.PourLiquid();
            Console.WriteLine($"{beverage.GetName()} is ready!");
        }
    }
}
