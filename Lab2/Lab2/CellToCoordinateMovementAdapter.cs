using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class CellToCoordinateMovementAdapter : ICoordinateMovement
    {
        CellMovement cellMovement;
        public CellToCoordinateMovementAdapter(CellMovement movement)
        {
            cellMovement = movement;
        }

        public void CoordinateMove()
        {
            cellMovement.CellMove();
        }
    }
}
