using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    abstract class Feature
    {
        public abstract Feature Clone();
        public abstract void GetInfo();
        protected static int count;
        protected int ID;
    }
}
