using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    interface IComponent
    {
        string Title { get; set; }
        void Draw();
        IComponent Find(string title);
    }
}
