using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciple
{
    class ToyDuck:Duck
    {
        String sound = "duck duck";
        override public String MakeSound(String sound) {
            return sound;
        }

        override public String Live(String food) {

            return "dont need food";
        }
    }
}
