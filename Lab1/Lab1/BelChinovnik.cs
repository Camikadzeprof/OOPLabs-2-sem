using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class BelChinovnik : Chinovnik
    {
        public override void Say()
        {
            Console.WriteLine("Ты видишь вирусы?... И я невижу. Их здесь нет.");
        }
    }
}
