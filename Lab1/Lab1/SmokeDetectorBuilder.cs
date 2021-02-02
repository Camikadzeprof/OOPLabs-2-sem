using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class SmokeDetectorBuilder : DetectorBuilder
    {
        public override void SetType()
        {
            this.Detector.Type = new Type { Name = "Дымовой" };
        }
        public override void SetMaterial()
        {
            this.Detector.Material = new Material { Name = "Пластик" };
        }
        public override void SetColor()
        {
            this.Detector.Color = new Color { Name = "Белый" };
        }
    }
}
