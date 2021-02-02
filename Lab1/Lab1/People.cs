using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class People
    {
        private List<GlavDoctor> doctors = new List<GlavDoctor>();
        private List<Chinovnik> chins = new List<Chinovnik>();
        public People(PeopleFactory factory, int countDoctor, int countTeacher)
        {
            for (int i = 0; i < countDoctor; i++)
            {
                doctors.Add(factory.CreateDoctor());
            }
            for (int i = 0; i < countTeacher; i++)
            {
                chins.Add(factory.CreateChinovnik());
            }
        }

        public void Health(int n)
        {
            Console.WriteLine("Состоние здоровья: ");
            doctors[n - 1].Health();
        }

        public void Say(int n)
        {
            chins[n - 1].Say();
        }
    }
}
