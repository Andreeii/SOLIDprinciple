using System;

namespace SOLIDprinciple
{
    class MainClass
    {
        static void Main(string[] args)
        {
            String t = "afasdfsdaf";
            Iphone iphone5 = new Iphone();

            TeslaCar tesla = new TeslaCar();

            iphone5.isOpen = true;
            iphone5.Texting(t);

            Console.WriteLine(tesla.Close());
        }
    }

}
