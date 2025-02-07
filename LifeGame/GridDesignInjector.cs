using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    internal class GridDesignInjector
    {
        private IGridDesign iGridDesign;

        public GridDesignInjector(IGridDesign iGrid)
        {
            this.iGridDesign = iGrid;
        }

        public void gridDraw()
        {
            iGridDesign.drawGrid();
        }
    }
}
