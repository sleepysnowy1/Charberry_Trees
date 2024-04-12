using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charberry_Trees
{
    internal class CharberryTree
    {
        private Random _random = new Random();
        public bool Ripe { get; set; }

        public event Func<bool>? Ripened;

        public void MaybeGrow()
        {
            if(_random.NextDouble() < 0.00000001 && !Ripe)
            {
                Ripe = true;
                Ripe = Ripened?.Invoke(); 
            }
        }
    }
}
