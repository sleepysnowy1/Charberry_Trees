using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charberry_Trees
{
    internal class Harvester
    {
        
        public Harvester(CharberryTree tree)
        {
            tree.Ripened += HarvestTree; 
        }

        public bool HarvestTree()
        {
            return false;
        }
    }
}
