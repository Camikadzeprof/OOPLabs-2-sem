using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class OtherCountryChinovnik : Chinovnik
    {
        public override void Say()
        {
            Console.WriteLine("Мы вводим карантин");
        }
    }
}
