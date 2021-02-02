using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class GameMemento
    {
        public int Level { get; private set; }
        public int Score { get; private set; }

        public GameMemento(int level, int score)
        {
            this.Level = level;
            this.Score = score;
        }
    }
}
