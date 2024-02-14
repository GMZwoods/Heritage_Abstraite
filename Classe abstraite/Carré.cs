using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_abstraite
{
    internal class Carré : Rectangle
    {
        public Carré(int cgX, int cgY, double c) : base (cgX, cgY, c, c)
        {
            
        }
    }
}
