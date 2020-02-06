using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciple
{
    class TeslaCar : IDevice
    {
        int IDevice.Ram { set; get; }
        String IDevice.Color { set; get; }


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
        public void Texting(String text)
        {

            Console.WriteLine("Car is writeing message" + text);

        }

        public String Runing()
        {

            return "This car is runing";
        }
    }
}
