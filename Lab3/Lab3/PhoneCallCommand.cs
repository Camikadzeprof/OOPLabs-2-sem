using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class PhoneCallCommand : ICommand
    {
        Phone phone;

        public PhoneCallCommand(Phone mPhone)
        {
            phone = mPhone;
        }

        public void Execute()
        {
            phone.Call();
        }

        public void Undo()
        {
            phone.EndCall();
        }
    }
}
