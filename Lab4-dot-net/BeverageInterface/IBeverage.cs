using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_dot_net.BeverageInterface
{
    public interface IBeverage
    {
        string GetName();
        void ChooseCup();
        void AddIngredients();
        void PourLiquid();
    }
}
