using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class PlanetName
    {
        private static PlanetName instance;

        public string Name { get; private set; }

        protected PlanetName(string name)
        {
            this.Name = name;
        }

        public static PlanetName getInstance(string name)
        {
            if (instance == null)
                instance = new PlanetName(name);
            return instance;
        }
    }
}
