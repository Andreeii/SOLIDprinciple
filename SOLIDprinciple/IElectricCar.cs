using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciple
{
    interface IElectricCar
    {
        public String Runing();
        public String Color { set; get; }

        public bool Open();
        public bool Close();
    }
}
