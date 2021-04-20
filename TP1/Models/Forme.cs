using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Models
{
    public abstract class Forme
    {
        public abstract double Aire();
        public abstract double Perimetre();
        public override string ToString()
        {
            return "Aire = " + Aire() + Environment.NewLine + "Périmètre = " + Perimetre() + Environment.NewLine ;
        }
    }
}
