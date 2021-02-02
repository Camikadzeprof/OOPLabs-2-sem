using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class JacketHuman : HumanDecorator
    {
        public JacketHuman(Human human) : base(human.Name + " в куртке", human)
        { }
        public override string GetWeather()
        {
            return "Сильный ветер, поэтому ";
        }
    }
}
