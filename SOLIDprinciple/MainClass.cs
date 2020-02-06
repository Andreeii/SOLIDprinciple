using System;

namespace SOLIDprinciple
{
    class MainClass
    {
        static void Main(string[] args)
        {
            String t = "afasdfsdaf";
            Iphone nokia = new Iphone();

            TeslaCar tesla = new TeslaCar();

            nokia.isOpen = true;

            Console.WriteLine(tesla.Close());
        }
    }

}
