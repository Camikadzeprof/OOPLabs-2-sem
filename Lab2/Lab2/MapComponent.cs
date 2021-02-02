using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class MapComponent : IComponent
    {
        public string Title { get; set; }
        public void Draw()
        {
            Console.WriteLine(Title);
        }
        public IComponent Find(string title)
        {
            return Title == title ? this : null;
        }
    }
}
