using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciple
{
    class AirDelivery:IDelivery
    {
        public double Weight;
        public double Cost;


        public AirDelivery(double Weight) {

            this.Weight = Weight;
        }


        public override string GetCost() {

            Cost = Weight * 2;
            return ("The cost of this delivery will be "+Cost+"$");

        }
    }
}
