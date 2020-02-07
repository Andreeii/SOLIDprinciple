using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciple
{
    class WaterDelivery:IDelivery
    {
        public double Weight;
        public double Cost;


        public WaterDelivery(double Weight)
        {

            this.Weight = Weight;
        }


        public override string GetCost()
        {

            Cost = Weight * 1.5;
            return ("The cost of this delivery will be "+Cost+ "$");

        }
    }
}
