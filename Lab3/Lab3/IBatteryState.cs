using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    interface IBatteryState
    {
        void Charge(Battery battery);
        void Discharge(Battery battery);
    }
}
