using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoClassLibrary
{
    public class Samourai: IdEntity
    {    
        public int Force { get; set; }
        public string Nom { get; set; }
        public virtual Arme Arme { get; set; }
        public virtual ArtMartial ArtMartial { get; set; }
        public virtual List<ArtMartial> ArtMartials { get; set; } = new List<ArtMartial>();

    }
}
