using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    internal class OrganismPaintingInjector
    {
        private IOrganismPainting iPainting;

        public OrganismPaintingInjector(IOrganismPainting iPaintingOrg)
        {
            this.iPainting = iPaintingOrg;
        }

        public void organismsPaint()
        {
            iPainting.paintOrganisms();
        }
    }
}
