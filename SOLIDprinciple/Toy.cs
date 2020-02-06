using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDprinciple
{
    abstract class Toy
    {

        public int price { set; get; }

        abstract public bool IsSound();
    }
}
