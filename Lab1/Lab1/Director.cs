using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Director
    {
        public Detector Make(DetectorBuilder detectorBuilder)
        {
            detectorBuilder.CreateDetector();
            detectorBuilder.SetType();
            detectorBuilder.SetMaterial();
            detectorBuilder.SetColor();
            return detectorBuilder.Detector;
        }
    }
}
