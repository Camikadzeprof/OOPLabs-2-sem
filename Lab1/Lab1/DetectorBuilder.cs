using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    abstract class DetectorBuilder
    {
        public Detector Detector { get; private set; }
        public void CreateDetector()
        {
            Detector = new Detector();
        }
        public abstract void SetType();
        public abstract void SetMaterial();
        public abstract void SetColor();
    }
}
