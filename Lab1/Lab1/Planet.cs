using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Planet
    {
        public PlanetName PlanetName { get; set; }
        public void GiveName(string planetName)
        {
            PlanetName = PlanetName.getInstance(planetName);
        }
    }
}
