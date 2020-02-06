using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciple
{
    interface IDevice
    {

        public int Ram { set; get; }
        public String Color { set; get; }

        public bool Open();
        public bool Close();

        public void Texting(String text);

        public String Runing();
    }
}
