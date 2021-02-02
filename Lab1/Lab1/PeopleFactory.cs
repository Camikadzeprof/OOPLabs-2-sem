using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    abstract class PeopleFactory
    {
        public abstract GlavDoctor CreateDoctor();
        public abstract Chinovnik CreateChinovnik();
    }
}
