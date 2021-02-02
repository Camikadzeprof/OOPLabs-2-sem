using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class European : Feature
    {
        string skinColor;
        protected new static int count;

        public European(string sc)
        {
            skinColor = sc;
            ID = ++count;
        }
        public override Feature Clone()
        {
            return new European(this.skinColor);
        }
        public override void GetInfo()
        {
            Console.WriteLine($"{skinColor} цвет кожи у {ID}-го европейца");
        }
    }
}
