using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciple
{
    class VoicelessDuck:Duck
    {
        public String sound = "no sound";
        public String food = "seeds";

        override public String MakeSound() {

            return sound;
        }

        override public  String Live() {

            return "happy , want more"+ food;
        }

    }
}
