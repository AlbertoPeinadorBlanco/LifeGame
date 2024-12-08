using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    internal class GridCoordinates
    {
        public List<Point> cellCordinates(int cellSize, Point pointA)
        {
            pointA.X = 0;
            pointA.Y = 0;

            List<Point> points = new List<Point>();

            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    points.Add(pointA);

                    if(pointA.X < cellSize * 50)
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
