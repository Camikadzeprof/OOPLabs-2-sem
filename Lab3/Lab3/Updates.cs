using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Updates : IObservable
    {
        UpdatesInfo uInfo; // информация об обновлениях

        List<IObserver> observers;
        public Updates()
        {
            observers = new List<IObserver>();
            uInfo = new UpdatesInfo();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(uInfo);
            }
        }

        public void Version()
        {
            Random rnd = new Random();
            uInfo.Android = rnd.Next(8, 10);
            uInfo.IOS = rnd.Next(11, 13);
            NotifyObservers();
        }
    }
}
