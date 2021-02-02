using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Asian : Feature
    {
        double eyeWidth;
        protected new static int count;

        public Asian(double w)
        {
            eyeWidth = w;
            ID = ++count;
        }
        public override Feature Clone()
        {
            return new Asian(this.eyeWidth);
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Глаз {ID}-го азиата с шириной: {eyeWidth}см");
        }
    }
}
