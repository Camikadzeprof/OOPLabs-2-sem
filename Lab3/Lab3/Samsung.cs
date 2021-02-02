using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Samsung : IObserver
    {
        public string Name { get; set; }
        IObservable update;
        public Samsung(string name, IObservable obs)
        {
            this.Name = name;
            update = obs;
            update.RegisterObserver(this);
        }
        public void Update(object ob)
        {
            UpdatesInfo uInfo = (UpdatesInfo)ob;

            if (uInfo.Android < 9)
                Console.WriteLine("Компания {0} выпускает обновление Android; Текущая версия: {1}", this.Name, uInfo.Android);
            else
                Console.WriteLine("Компания {0} уже обновила устройства; Версия: {1}", this.Name, uInfo.Android);
        }
        public void StopUpdate()
        {
            update.RemoveObserver(this);
            update = null;
        }
    }
}
