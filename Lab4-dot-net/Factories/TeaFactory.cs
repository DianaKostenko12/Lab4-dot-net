﻿using Lab4_dot_net.BeverageInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_dot_net.BeverageFactoryInterface
{
    public class TeaFactory : IBeverageFactory
    {
        public IBeverage CreateBeverage(string size) 
        { 
            return new Tea(size); 
        }
    }
}
