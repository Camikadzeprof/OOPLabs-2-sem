using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class GameHistory
    {
        public Stack<GameMemento> History { get; private set; }
        public GameHistory()
        {
            History = new Stack<GameMemento>();
        }
    }
}
