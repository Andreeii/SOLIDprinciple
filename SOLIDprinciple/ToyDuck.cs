using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciple
{
    class ToyDuck:Duck
    {
        String sound = "duck duck";
        override public String MakeSound() {
            return sound;
        }

        //violating liskovSubstitution
        override public String Live() {

            return "dont need food";
        }
    }
}
