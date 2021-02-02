using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Phone
    {
        public void Call()
        {
            Console.WriteLine("Вызов абонента");
        }
        public void EndCall()
        {
            Console.WriteLine("Завершние вызова");
        }

        public void SendMessege()
        {
            Console.WriteLine("Отпрака сообщения");
        }

        public void CancelMessege()
        {
            Console.WriteLine("Отмена отправки");
        }
    }
}
