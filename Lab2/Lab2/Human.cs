using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    abstract class Human
    {
        public string Name { get; protected set; }
        public Human(string name)
        {
            this.Name = name;
        }
        public abstract string GetWeather();
    }
}
