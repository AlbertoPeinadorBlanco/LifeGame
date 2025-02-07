using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    internal class Organism
    {
        public bool isAlive;
        public Point startDrawingPoint;
        public int cellSide;
        public Organism(Point p, bool b, int side)
        {
            this.startDrawingPoint = p;
            this.cellSide = side;
            this.isAlive = b;
        }

        public Organism Clone()
        {
            return new Organism(this.startDrawingPoint, this.isAlive, this.cellSide);
        }

       
    }
}
