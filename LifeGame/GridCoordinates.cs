using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    internal class GridCoordinates : IGridCoordinates
    {
        public List<Point> cellCordinates(int cellSize, Point pointA)
        {
            pointA.X = 0;
            pointA.Y = 0;
            int gridSide = 50;

            List<Point> points = new List<Point>();

            for (int i = 0; i < gridSide; i++)
            {
                for (int j = 0; j < gridSide; j++)
                {
                    points.Add(pointA);

                    if(pointA.X < (cellSize * gridSide) - cellSize)
                    {
                        pointA.X += cellSize;

                    }
                    else
                    {
                        pointA.X = 0;
                    }
                }
                pointA.Y += cellSize;
            }
            return points;
        }
    }
}
