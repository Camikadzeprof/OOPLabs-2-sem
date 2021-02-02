using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class BelPeopleFactory : PeopleFactory
    {
        public override GlavDoctor CreateDoctor()
        {
            return new BelGlavDoctor();
        }

        public override Chinovnik CreateChinovnik()
        {
            return new BelChinovnik();
        }
    }
}
