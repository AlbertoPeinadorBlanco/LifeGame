using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    internal class OrganismPainting : IOrganismPainting
    {

        private Bitmap bm;
        private PictureBox pb;
        private Graphics g;

        public OrganismPainting(Bitmap m, PictureBox p, Graphics gr)
        {
            this.bm = m;
            this.pb = p;
            this.g = gr;
        }
        public void paintOrganisms()
        {
            SolidBrush cellBrush = new SolidBrush(Color.Green);
            Point coordinate = new Point();

            foreach (Organism o in OrganismsList.organismList)
            {
                coordinate = o.startDrawingPoint;

                if (o.isAlive)
                {
                    g.FillRectangle(cellBrush, coordinate.X, coordinate.Y, o.cellSide, o.cellSide);
                    pb.Image = (Bitmap)bm.Clone();

                }
            }

        }
    }
}
