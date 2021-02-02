using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Finger
    {
        ICommand touch;

        public Finger()
        {

        }

        public void SetCommand(ICommand command)
        {
            touch = command;
        }

        public void PressButton()
        {
            touch.Execute();
        }

        public void PressUndo()
        {
            touch.Undo();
        }
    }
}
