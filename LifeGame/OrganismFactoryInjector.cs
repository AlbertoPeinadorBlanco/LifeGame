using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    internal class OrganismFactoryInjector
    {
        private IOrganismFactory iOrganism;

        public OrganismFactoryInjector(IOrganismFactory iFactory)
        {
            this.iOrganism = iFactory;
        }

        public void organismCreation()
        {
            iOrganism.createOrganism();
        }
    }
}
