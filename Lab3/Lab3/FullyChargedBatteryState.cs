using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class FullyChargedBatteryState : IBatteryState
    {
        public void Charge(Battery battery)
        {
            Console.WriteLine("Аккумулятор полностью заряжен");
            battery.State = new FullyChargedBatteryState();
        }

        public void Discharge(Battery battery)
        {
            Console.WriteLine("Частично разряжаем аккумулятор");
            battery.State = new PartiallyChargedBatteryState();
        }
    }
}
