using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class UmbrellaHuman : HumanDecorator
    {
        public UmbrellaHuman(Human human) : base(human.Name + " с зонтиком", human)
        { }
        public override string GetWeather()
        {
            return "Идёт дождь, поэтому ";
        }
    }
}
