using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Battery
    {
        public IBatteryState State { get; set; }

        public Battery(IBatteryState bs)
        {
            State = bs;
        }

        public void Charge()
        {
            State.Charge(this);
        }

        public void Discharge()
        {
            State.Discharge(this);
        }
    }
}
