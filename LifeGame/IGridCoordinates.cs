using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    internal interface IGridCoordinates
    {
        List<Point> cellCordinates(int cellSize, Point pointA);
    }
}
