using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class PartiallyChargedBatteryState : IBatteryState
    {
        public void Charge(Battery battery)
        {
            Console.WriteLine("Полностью заряжаем аккумулятор");
            battery.State = new FullyChargedBatteryState();
        }

        public void Discharge(Battery battery)
        {
            Console.WriteLine("Аккумулятор полностью разряжен");
            battery.State = new FullyDischargedBatteryState();
        }
    }
}
