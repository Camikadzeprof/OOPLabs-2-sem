using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class CoordinateMovement : ICoordinateMovement
    {
        public void CoordinateMove()
        {
            Console.WriteLine("Введите координаты X и Y: ");
            int x, y;
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out x))
                    break;
                else
                    Console.WriteLine("Неверно введено значение \nВведите координату X еще раз: ");
            }
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out y))
                    break;
                else
                    Console.WriteLine("Неверно введено значение \nВведите координату Y еще раз: ");
            }
            Console.WriteLine($"Человек перемещается на координату ({x},{y}).");
        }
    }
}
