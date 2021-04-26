using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TP6.Data
{
    public class TP6Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TP6Context() : base("name=TP6Context")
        {
        }

        public System.Data.Entity.DbSet<DojoClassLibrary.Samourai> Samourais { get; set; }

        public System.Data.Entity.DbSet<DojoClassLibrary.Arme> Armes { get; set; }
    }
}
