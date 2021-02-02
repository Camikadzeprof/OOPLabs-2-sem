using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1");
            People other = new People(new OtherPeopleFactory(), 5, 2);
            other.Health(2);
            other.Say(2);
            Console.WriteLine();

            People bel = new People(new BelPeopleFactory(), 3, 10);
            bel.Health(2);
            bel.Say(8);
            Console.WriteLine();


            Console.WriteLine("Задание №2");
            Planet planet = new Planet();
            planet.GiveName("Earth");
            Console.WriteLine("Планета - " + planet.PlanetName.Name + "\n");


            Console.WriteLine("Задание №3");
            Director fabricator = new Director();
            DetectorBuilder builder = new SmokeDetectorBuilder();
            Detector smokeDetector = fabricator.Make(builder);
            Console.WriteLine(smokeDetector.ToString());

            builder = new ThermalDetectorBuilder();
            Detector thermalDetector = fabricator.Make(builder);
            Console.WriteLine(thermalDetector.ToString());

            builder = new FlameDetectorBuilder();
            Detector flameDetector = fabricator.Make(builder);
            Console.WriteLine(flameDetector.ToString());


            Console.WriteLine("Задание №4");
            Feature feature = new Asian(1.30);
            Feature clonedFeature = feature.Clone();
            feature.GetInfo();
            clonedFeature.GetInfo();
            Console.WriteLine();

            feature = new European("Белый");
            clonedFeature = feature.Clone();
            feature.GetInfo();
            clonedFeature.GetInfo();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
