using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Models
{
    public class Rectangle:Forme
    {
        public int Longueur { get; set; }
        public int Largeur { get; set; }

        public override double Aire()
        {
            return Math.Sqrt;
        }

        public override double Perimetre()
        {
            return 2 * (Longueur + Largeur);
        }
    }
}
