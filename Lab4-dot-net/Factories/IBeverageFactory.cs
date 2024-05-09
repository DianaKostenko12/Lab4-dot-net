using Lab4_dot_net.BeverageInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_dot_net.BeverageFactoryInterface
{
    public interface IBeverageFactory
    {
        IBeverage CreateBeverage(string size);
    }
}
