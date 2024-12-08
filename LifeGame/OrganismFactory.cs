using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    internal class OrganismFactory : IOrganismFactory
    {
        Random rdn = new Random();

        private List<Point> points;
        private Organism org;
        private int organismSide;


        public OrganismFactory(List<Point> lp, int size) 
        {
            this.points = lp;
            this.organismSide = size;
            
        }
        
        public void createOrganism()
        {

            foreach (Point point in points)
            {
                bool isAlive;
                int number = rdn.Next(100);

                if (number < 20)
                {
                    isAlive = true;
                }
                else
                {
                    isAlive = false;
                }

                org = new Organism(point, isAlive, organismSide);

                OrganismsList.organismList.Add(org);

            }

        }

    }
}
