using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    internal class GridDesign
    {
        private PictureBox cPbGrid;
        private Point cPointA;
        private Point cPointB;
        private Pen cPen;
        private Graphics g;
        private Bitmap btm;

        public GridDesign(PictureBox pbGrid, Point pointA, Point pointB, Pen pen, Graphics gr, Bitmap btmp)
        {
            this.cPbGrid = pbGrid;
            this.cPointA = pointA;
            this.cPointB = pointB;
            this.cPen = pen;
            this.g = gr;
            this.btm = btmp;
        }

        public void drawGrid()
        {

            int cellSize = cPbGrid.Width / 50;

            cPointA.X = 0;
            cPointA.Y = 0;
            cPointB.X = 0;
            cPointB.Y = cPbGrid.Height;

            for (int i = 0; i <= 50; i++)
            {  
                g.DrawLine(cPen, cPointA, cPointB);
                cPointA.X += cellSize;
                cPointB.X += cellSize;

            }

            cPointA.X = 0;
            cPointA.Y = 0;
            cPointB.X = cPbGrid.Width;
            cPointB.Y = 0;

            for (int j = 0; j <= 50; j++)
            {
                g.DrawLine(cPen, cPointA, cPointB);
                cPointA.Y += cellSize;
                cPointB.Y += cellSize;
            }

            cPbGrid.Image = (Bitmap)btm.Clone();

        }
     
    }
}
