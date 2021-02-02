using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class OtherPeopleFactory : PeopleFactory
    {
        public override GlavDoctor CreateDoctor()
        {
            return new OtherGlavDoctor();
        }

        public override Chinovnik CreateChinovnik()
        {
            return new OtherCountryChinovnik();
        }
    }
}
