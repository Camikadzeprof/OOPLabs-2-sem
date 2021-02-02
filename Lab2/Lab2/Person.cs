using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Person
    {
        public void Move(ICoordinateMovement person)
        {
            person.CoordinateMove();
        }
    }
}
