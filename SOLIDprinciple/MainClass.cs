using System;

namespace SOLIDprinciple
{
    class MainClass
    {
        static void Main(string[] args)
        {
            String t = "afasdfsdaf";
            SmartPhone nokia = new SmartPhone();

            TeslaCar tesla = new TeslaCar();

            nokia.isOpen = true;

            Console.WriteLine(tesla.Close());
        }
    }

}
