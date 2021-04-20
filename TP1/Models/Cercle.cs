using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Models
{
    public class Cercle : Forme
    {
        public int Rayon { get; set; }

        public override double Aire()
        {
            return Rayon * Rayon * Math.PI;
        }

        public override double Perimetre()
        {
            return 2 * Rayon * Math.PI;
        }

    }
}
