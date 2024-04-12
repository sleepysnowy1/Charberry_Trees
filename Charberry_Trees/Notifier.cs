using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Charberry_Trees
{
    internal class Notifier
    {
        public bool OnTreeRipened()
        {
            Console.WriteLine("The tree ripened.");
            return true;
        }  
        public Notifier(CharberryTree tree)
        {
            tree.Ripened += OnTreeRipened;
        }
    }


}
