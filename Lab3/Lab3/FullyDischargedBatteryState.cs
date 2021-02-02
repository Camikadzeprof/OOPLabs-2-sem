using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class FullyDischargedBatteryState : IBatteryState
    {
        public void Charge(Battery battery)
        {
            Console.WriteLine("Частично заряжаем аккумулятор");
            battery.State = new PartiallyChargedBatteryState();
        }

        public void Discharge(Battery battery)
        {
            Console.WriteLine("Аккумулятор полностью разряжен");
            battery.State = new FullyDischargedBatteryState();
        }
    }
}
