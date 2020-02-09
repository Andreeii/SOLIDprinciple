using System;

namespace SOLIDprinciple
{
    class MainClass
    {
        static void Main(string[] args)
        {
            String t = "afasdfsdaf";
<<<<<<< HEAD
            Iphone nokia = new Iphone();
=======
            Iphone iphone5 = new Iphone();
>>>>>>> a3b4ebccbbe85cec80d557a599d8b0e44e47f839

            TeslaCar tesla = new TeslaCar();

            iphone5.isOpen = true;
            iphone5.Texting(t);

            Console.WriteLine(tesla.Close());
        }
    }

}
