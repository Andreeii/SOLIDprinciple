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

            duck1.MakeSound();

            duck1.Live();

        }
    }

}
