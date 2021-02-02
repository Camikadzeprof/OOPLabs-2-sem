using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class SendMessageCommand : ICommand
    {
        Phone messege;

        public SendMessageCommand(Phone mes)
        {
            messege = mes;
        }

        public void Execute()
        {
            messege.SendMessege();
        }

        public void Undo()
        {
            messege.CancelMessege();
        }
    }
}
