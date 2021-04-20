using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Models
{
    public class Triangle:Forme
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public override string Presentation()
        {
            return "triangle de coté A= " + A + ", B=" + B + " et C=" + C;
        }

        public override string Aire()
        {
            return "Aire = " + ;
        }

        public override string Perimetre()
        {
            return "Périmètre = " + A + B+ C;
        }
    }
}
