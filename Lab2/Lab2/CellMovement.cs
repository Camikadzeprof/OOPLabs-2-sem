using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class CellMovement : ICellMovement
    {
        public void CellMove()
        {
            Console.WriteLine("Введите количество клеток");
            int x;
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out x))
                    break;
                else
                    Console.WriteLine("Неверно введено значение \nВведите кол-во клеток еще раз: ");
            }
            Console.WriteLine($"Человек перемещается на количество клеток: {x}");
        }
    }
}
