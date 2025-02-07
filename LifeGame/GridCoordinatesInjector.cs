using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    internal class GridCoordinatesInjector
    {
        private IGridCoordinates iGridCoordinates;
        public GridCoordinatesInjector(IGridCoordinates iCoordinates)
        {
            this.iGridCoordinates = iCoordinates;
        }

        public List<Point> getCoordinates(int size, Point point)
        {
            return iGridCoordinates.cellCordinates(size, point);
        }
    }
}
