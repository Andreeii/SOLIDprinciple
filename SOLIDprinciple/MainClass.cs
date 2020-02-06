using System;
using System.Collections.Generic;

namespace SOLIDprinciple
{
    class MainClass
    {
        static void Main(string[] args)
        {

            VoicelessDuck duck1 = new VoicelessDuck();

            ToyDuck duck2 = new ToyDuck();

           Console.WriteLine(duck1.MakeSound());

            Console.WriteLine(duck1.Live());

        }
    }

}
