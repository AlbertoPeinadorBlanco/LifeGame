using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    internal class OrganismReproduction //: OrganismFactory
    {

        private int sizeCell;

        private Point point;
        private Point pointUp;
        private Point pointDown;
        private Point pointLeft;
        private Point pointRight;
        
        private Point pointTopLeft;
        private Point pointTopRight;
        private Point pointBottomLeft;
        private Point pointBottomRight;

        private int reproducingOrganisms;
        private List<Organism> orList = new List<Organism>();

        public OrganismReproduction(int size) //: base(lp, size)
        {
            this.sizeCell = size;
          
        }
        public void checkReproduction()
        {

            foreach(Organism org in OrganismsList.organismList)
            {
                orList.Add(org.Clone());
            }

            int tracking = 0;

            foreach (Organism org in OrganismsList.organismList)
            {
                int counter = 0;
                tracking++;

                point = org.startDrawingPoint;

                pointUp.X = org.startDrawingPoint.X;
                pointUp.Y = org.startDrawingPoint.Y - sizeCell;

                pointDown.X = org.startDrawingPoint.X;
                pointDown.Y = org.startDrawingPoint.Y + sizeCell;

                pointRight.X = org.startDrawingPoint.X + sizeCell;
                pointRight.Y = org.startDrawingPoint.Y;

                pointLeft.X = org.startDrawingPoint.X - sizeCell;
                pointLeft.Y = org.startDrawingPoint.Y;

                pointBottomLeft.X = org.startDrawingPoint.X - sizeCell;
                pointBottomLeft.Y = org.startDrawingPoint.Y + sizeCell;

                pointBottomRight.X = org.startDrawingPoint.X + sizeCell;
                pointBottomRight.Y = org.startDrawingPoint.Y + sizeCell;

                pointTopLeft.X = org.startDrawingPoint.X - sizeCell;
                pointTopLeft.Y = org.startDrawingPoint.Y - sizeCell;

                pointTopRight.X = org.startDrawingPoint.X + sizeCell;
                pointTopRight.Y = org.startDrawingPoint.Y - sizeCell;

            
                if(org.startDrawingPoint.X == 0 && org.startDrawingPoint.Y == 0)
                {
                    Organism orRight = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointRight.X &&
                    x.startDrawingPoint.Y == pointRight.Y);

                    Organism orDown = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointDown.X &&
                    x.startDrawingPoint.Y == pointDown.Y);

                    Organism orDownRight = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointBottomRight.X &&
                    x.startDrawingPoint.Y == pointBottomRight.Y);

                    if (orRight != null && orRight.isAlive)
                    {
                        counter++;
                    }
                    if(orDown != null && orDown.isAlive)
                    {
                        counter++;
                    }
                    if(orDownRight != null && orDownRight.isAlive)
                    {
                        counter++;
                    }


                }
                if (org.startDrawingPoint.X == 0 && org.startDrawingPoint.Y == (sizeCell * 50) - sizeCell)
                {
                    Organism orTop = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointUp.X &&
                    x.startDrawingPoint.Y == pointUp.Y);

                    Organism orRight = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointRight.X &&
                    x.startDrawingPoint.Y == pointRight.Y);

                    Organism orTopRight = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointTopRight.X &&
                    x.startDrawingPoint.Y == pointTopRight.Y);

                    if (orRight != null && orRight.isAlive)
                    {
                        counter++;
                    }
                    if (orTop != null && orTop.isAlive)
                    {
                        counter++;
                    }
                    if (orTopRight != null && orTopRight.isAlive)
                    {
                        counter++;
                    }

                }
                if(org.startDrawingPoint.X == 0 && org.startDrawingPoint.Y > 0 && org.startDrawingPoint.Y < (sizeCell * 50) - sizeCell)
                {
                    Organism orDown = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointDown.X &&
                    x.startDrawingPoint.Y == pointDown.Y);

                    Organism orRight = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointRight.X &&
                    x.startDrawingPoint.Y == pointRight.Y);

                    Organism orTopRight = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointTopRight.X &&
                    x.startDrawingPoint.Y == pointTopRight.Y);

                    Organism orTop = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointUp.X &&
                    x.startDrawingPoint.Y == pointUp.Y);

                    Organism orBottomRight = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointBottomRight.X &&
                    x.startDrawingPoint.Y == pointBottomRight.Y);

                    if (orRight != null && orRight.isAlive)
                    {
                        counter++;
                    }
                    if (orDown != null && orDown.isAlive)
                    {
                        counter++;
                    }
                    if (orTopRight != null && orTopRight.isAlive)
                    {
                        counter++;
                    }
                    if(orTop != null && orTop.isAlive)
                    {
                        counter++;
                    }
                    if(orBottomRight != null && orBottomRight.isAlive)
                    {
                        counter++;
                    }

                }
                if(org.startDrawingPoint.X == (sizeCell * 50) - sizeCell && org.startDrawingPoint.Y == 0)
                {
                    Organism orDown = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointDown.X &&
                    x.startDrawingPoint.Y == pointDown.Y);

                    Organism orBottomLeft = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointBottomLeft.X &&
                    x.startDrawingPoint.Y == pointBottomLeft.Y);

                    Organism orLeft = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointLeft.X &&
                    x.startDrawingPoint.Y == pointLeft.Y);

                    if (orDown != null && orDown.isAlive)
                    {
                        counter++;
                    }
                    if (orBottomLeft != null && orBottomLeft.isAlive)
                    {
                        counter++;
                    }
                    if (orLeft != null && orLeft.isAlive)
                    {
                        counter++;
                    }

                }
                if (org.startDrawingPoint.X == (sizeCell * 50) - sizeCell && org.startDrawingPoint.Y == (sizeCell * 50) - sizeCell)
                {
                    Organism orUp = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointUp.X &&
                    x.startDrawingPoint.Y == pointUp.Y);

                    Organism orUpLeft = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointTopLeft.X &&
                    x.startDrawingPoint.Y == pointTopLeft.Y);

                    Organism orLeft = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointLeft.X &&
                    x.startDrawingPoint.Y == pointLeft.Y);

                    if (orUp != null && orUp.isAlive)
                    {
                        counter++;
                    }
                    if (orUpLeft != null && orUpLeft.isAlive)
                    {
                        counter++;
                    }
                    if (orLeft != null && orLeft.isAlive)
                    {
                        counter++;
                    }

                }
                if (org.startDrawingPoint.X == (sizeCell * 50) - sizeCell && org.startDrawingPoint.Y > 0 && org.startDrawingPoint.Y < (sizeCell * 50) - sizeCell)
                {
                    Organism orUp = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointUp.X &&
                    x.startDrawingPoint.Y == pointUp.Y);

                    Organism orUpLeft = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointTopLeft.X &&
                    x.startDrawingPoint.Y == pointTopLeft.Y);

                    Organism orLeft = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointLeft.X &&
                    x.startDrawingPoint.Y == pointLeft.Y);

                    Organism orDown = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointDown.X &&
                    x.startDrawingPoint.Y == pointDown.Y);

                    Organism orBottomLeft = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointBottomLeft.X &&
                    x.startDrawingPoint.Y == pointBottomLeft.Y);

                    if (orUp != null && orUp.isAlive)
                    {
                        counter++;
                    }
                    if (orUpLeft != null && orUpLeft.isAlive)
                    {
                        counter++;
                    }
                    if (orLeft != null && orLeft.isAlive)
                    {
                        counter++;
                    }
                    if (orDown != null && orDown.isAlive)
                    {
                        counter++;
                    }
                    if (orBottomLeft != null && orBottomLeft.isAlive)
                    {
                        counter++;
                    }

                }
                if (org.startDrawingPoint.X > 0 && org.startDrawingPoint.X < (sizeCell * 50) -sizeCell && org.startDrawingPoint.Y == 0)
                {
                    Organism orLeft = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointLeft.X &&
                    x.startDrawingPoint.Y == pointLeft.Y);

                    Organism orDown = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointDown.X &&
                    x.startDrawingPoint.Y == pointDown.Y);

                    Organism orBottomLeft = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointBottomLeft.X &&
                    x.startDrawingPoint.Y == pointBottomLeft.Y);

                    Organism orBottomRight = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointBottomRight.X &&
                    x.startDrawingPoint.Y == pointBottomRight.Y);

                    Organism orRight = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointRight.X &&
                    x.startDrawingPoint.Y == pointRight.Y);

                    if (orLeft != null && orLeft.isAlive)
                    {
                        counter++;
                    }
                    if (orDown != null && orDown.isAlive)
                    {
                        counter++;
                    }
                    if (orBottomLeft != null && orBottomLeft.isAlive)
                    {
                        counter++;
                    }
                    if (orBottomRight != null && orBottomRight.isAlive)
                    {
                        counter++;
                    }
                    if (orRight != null && orRight.isAlive)
                    {
                        counter++;
                    }

                }
                if (org.startDrawingPoint.X > 0 && org.startDrawingPoint.X < (sizeCell * 50) - sizeCell && org.startDrawingPoint.Y == (sizeCell * 50) - sizeCell)
                {
                    Organism orLeft = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointLeft.X &&
                    x.startDrawingPoint.Y == pointLeft.Y);

                    Organism orRight = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointRight.X &&
                    x.startDrawingPoint.Y == pointRight.Y);

                    Organism orUp = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointUp.X &&
                    x.startDrawingPoint.Y == pointUp.Y);

                    Organism orUpLeft = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointTopLeft.X &&
                    x.startDrawingPoint.Y == pointTopLeft.Y);

                    Organism orTopRight = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointTopRight.X &&
                    x.startDrawingPoint.Y == pointTopRight.Y);

                    if (orLeft != null && orLeft.isAlive)
                    {
                        counter++;
                    }
                    if (orRight != null && orRight.isAlive)
                    {
                        counter++;
                    }
                    if (orUp != null && orUp.isAlive)
                    {
                        counter++;
                    }
                    if (orUpLeft != null && orUpLeft.isAlive)
                    {
                        counter++;
                    }
                    if (orTopRight != null && orTopRight.isAlive)
                    {
                        counter++;
                    }

                }
                if (org.startDrawingPoint.X > 0 && org.startDrawingPoint.X < (sizeCell * 50) - sizeCell && 
                    org.startDrawingPoint.Y > 0 && org.startDrawingPoint.Y < (sizeCell * 50) - sizeCell)
                {
                    Organism orLeft = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointLeft.X &&
                    x.startDrawingPoint.Y == pointLeft.Y);

                    Organism orRight = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointRight.X &&
                    x.startDrawingPoint.Y == pointRight.Y);

                    Organism orUp = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointUp.X &&
                    x.startDrawingPoint.Y == pointUp.Y);

                    Organism orUpLeft = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointTopLeft.X &&
                    x.startDrawingPoint.Y == pointTopLeft.Y);

                    Organism orTopRight = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointTopRight.X &&
                    x.startDrawingPoint.Y == pointTopRight.Y);

                    Organism orDown = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointDown.X &&
                    x.startDrawingPoint.Y == pointDown.Y);

                    Organism orBottomLeft = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointBottomLeft.X &&
                    x.startDrawingPoint.Y == pointBottomLeft.Y);

                    Organism orBottomRight = OrganismsList.organismList.Find(x => x is Organism && x.startDrawingPoint.X == pointBottomRight.X &&
                    x.startDrawingPoint.Y == pointBottomRight.Y);

                    if (orLeft != null && orLeft.isAlive)
                    {
                        counter++;
                    }
                    if (orRight != null && orRight.isAlive)
                    {
                        counter++;
                    }
                    if (orUp != null && orUp.isAlive)
                    {
                        counter++;
                    }
                    if (orUpLeft != null && orUpLeft.isAlive)
                    {
                        counter++;
                    }
                    if (orTopRight != null && orTopRight.isAlive)
                    {
                        counter++;
                    }
                    if (orDown != null && orDown.isAlive)
                    {
                        counter++;
                    }
                    if (orBottomLeft != null && orBottomLeft.isAlive)
                    {
                        counter++;
                    }
                    if (orBottomRight != null && orBottomRight.isAlive)
                    {
                        counter++;
                    }

                }

                Organism organism = orList.Find(x => x is Organism && x.startDrawingPoint.X == point.X && x.startDrawingPoint.Y == point.Y);

                if (organism != null)
                {
                    if (organism.isAlive)
                    {
                        if (counter < 2 || counter > 3)
                        {
                            organism.isAlive = false;
                        }
                    }
                    else
                    {
                        if (counter == 3)
                        {
                            organism.isAlive = true;
                        }
                    }
                }
            }

            OrganismsList.organismList = orList;
        }
    }
}




