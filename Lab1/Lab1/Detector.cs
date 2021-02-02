using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Detector
    {
        public Type Type { get; set; }
        public Material Material { get; set; }
        public Color Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Type != null)
                sb.Append("Тип извещателя: " + Type.Name + "\n");
            else
            {
                sb.Append("Тип извещателя: неизвестен \n");
            }
            if (Material != null)
                sb.Append("Материал: " + Material.Name + "\n");
            else
            {
                sb.Append("Материал: неизвестен \n");
            }
            if (Color != null)
                sb.Append("Цвет: " + Color.Name + " \n");
            else
            {
                sb.Append("Цвет: неокрашен \n");
            }
            return sb.ToString();
        }
    }
}
