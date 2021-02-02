using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Apple : IObserver
    {
        public string Name { get; set; }
        IObservable update;
        public Apple(string name, IObservable obs)
        {
            this.Name = name;
            update = obs;
            update.RegisterObserver(this);
        }
        public void Update(object ob)
        {
            UpdatesInfo uInfo = (UpdatesInfo)ob;

            if (uInfo.IOS < 13)
                Console.WriteLine("Компания {0} обновяет устройства ;  Текущая версия IOS: {1}", this.Name, uInfo.IOS);
            else
                Console.WriteLine("Компания {0} уже обновила устройства;  Версия: {1}", this.Name, uInfo.IOS);
        }
    }
}
