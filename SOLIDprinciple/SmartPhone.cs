using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciple
{
    class SmartPhone : IDevice
    {

        int IDevice.Ram { set; get; }
        String IDevice.Color { set; get; }


        public bool isOpen = false;

        public bool Open()
        {

            isOpen = true;

            Console.WriteLine("Phone is open for using");
            return isOpen;
        }

        public bool Close()
        {

            bool isOpen = false;

            Console.WriteLine("Phone is cloed for using");
            return isOpen;
        }

        public void Texting(String text)
        {

            if (isOpen == true)
            {
                Console.WriteLine("Device is writeing " + text);
            }
        }
        public String Runing()
        {

            return "this car is runing";
        }

    }
}
