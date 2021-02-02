using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter \n" + (new String('-', 30)));
            Person person = new Person();
            CoordinateMovement coordinateMovement = new CoordinateMovement();
            person.Move(coordinateMovement);

            CellMovement cellMovement = new CellMovement();
            ICoordinateMovement cell = new CellToCoordinateMovementAdapter(cellMovement);
            person.Move(cell);
            Console.WriteLine();


            Console.WriteLine("Decorator \n" + (new String('-', 30)));
            Human human1 = new Englishmen();
            human1 = new UmbrellaHuman(human1);
            Console.WriteLine(human1.GetWeather() + human1.Name);

            Human human2 = new Chinese();
            human2 = new JacketHuman(human2);
            Console.WriteLine(human2.GetWeather() + human2.Name);
            Console.WriteLine();


            Console.WriteLine("Composite \n" + (new String('-', 30)));
            Map worldMap = new Map { Title = "Карта мира" };
            worldMap.AddComponent(new MapComponent { Title = "Государство" });
            worldMap.AddComponent(new MapComponent { Title = "Река" });
            worldMap.AddComponent(new MapComponent { Title = "Ресурс" });
            Map map = new Map { Title = "Атлас" };
            map.AddComponent(worldMap);
            map.Draw();
            var find = map.Find("Государство");
            find.Draw();
            Console.ReadKey();
        }
    }
}
