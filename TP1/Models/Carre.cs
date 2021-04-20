using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Models
{
    public class Carre : Forme
    {
        public int Longueur { get; set; }
        public override string Presentation()
        {
            return "Carré de coté " + Longueur;
        }

        public override string Aire()
        {
            return "Aire = " + Longueur * Longueur;
        }

        public override string Perimetre()
        {
            return "Périmètre = " + 4 * Longueur;
        }
    }
}
