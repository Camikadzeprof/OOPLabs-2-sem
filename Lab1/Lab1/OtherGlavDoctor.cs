using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class OtherGlavDoctor : GlavDoctor
    {
        public override void Health()
        {
            Console.WriteLine("Ситуация тяжёлая, но наблюдается улучшение");
        }
    }
}
