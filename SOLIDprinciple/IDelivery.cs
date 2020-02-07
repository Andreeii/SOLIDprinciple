using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciple
{
    abstract class IDelivery
    {

        public double Weight;
        public double Cost;
        abstract public string GetCost();
    }
}
