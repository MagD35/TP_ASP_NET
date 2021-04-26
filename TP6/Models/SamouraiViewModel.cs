using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DojoClassLibrary;

namespace TP6.Models
{
    public class SamouraiViewModel
    {
        [Required]
        public Samourai Samourai { get; set; }
        public List<Arme> Armes { get; set; }

        public int? IdArme { get; set; }
    }
}