using System;
using System.Collections.Generic;

namespace SOLIDprinciple
{
    class MainClass
    {
        static void Main(string[] args)
        {

            Order order1 = new Order("air" ,25);
            Console.WriteLine(order1.SetShippingType());


            AirDelivery box1 = new AirDelivery(12);
            Console.WriteLine(box1.GetCost());

            WaterDelivery box2 = new WaterDelivery(15);
            Console.WriteLine(box2.GetCost());
        }

    }

    class Order
    {


        public string deliveryway;
        public double weight;
        public double cost;

        public Order(string deliveryway, double weight)
        {
            this.deliveryway = deliveryway;
            this.weight = weight;
        }



        public string SetShippingType()
        {

            if (deliveryway == "ground")
            {
                cost = weight * 1.5;
                return (deliveryway + cost);
            }
            else if (deliveryway == "air")
            {
                cost = weight * 2;
                return (deliveryway + cost);
            }
            else
                return "delivery way is not found";

        }



    }

}
