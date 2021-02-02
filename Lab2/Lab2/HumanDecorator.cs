using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    abstract class HumanDecorator : Human
    {
        protected Human human;
        public HumanDecorator(string name, Human human) : base(name)
        {
            this.human = human;
        }
    }
}
