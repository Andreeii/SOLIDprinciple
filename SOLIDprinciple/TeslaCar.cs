using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciple
{
    class TeslaCar : IElectricCar
    {
        String IElectricCar.Color { set; get; }


        public bool isOpen = false;

        public bool Open()
        {

            isOpen = true;

            Console.WriteLine("Car dors are open for using");
            return isOpen;
        }
        public bool Close()
        {

            bool isOpen = false;

            Console.WriteLine("Car dors are cloed for using");
            return isOpen;
        }
//no need to implement functionality for texting method in car class

        public String Runing()
        {

            return "This car is runing";
        }
    }
}
