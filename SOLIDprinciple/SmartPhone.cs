using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciple
{
    class Iphone : ISmartPhone
    {

        int ISmartPhone.Ram { set; get; }
        String ISmartPhone.Color { set; get; }


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
//no ned to provide implementation of runing method  that don't have dirct relationship to this class

    }
}
