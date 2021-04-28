using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DojoClassLibrary;

namespace TP7.Data
{
    public class TP7Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TP7Context() : base("name=TP7Context")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Samourai>().HasOptional(s => s.Arme).WithOptionalPrincipal();
            modelBuilder.Entity<Samourai>().HasMany(x => x.ArtMartials).WithMany();

                //HasOptional(s => s.ArtsMartiaux).WithMany();

        }

        public System.Data.Entity.DbSet<DojoClassLibrary.Samourai> Samourais { get; set; }

        public System.Data.Entity.DbSet<DojoClassLibrary.Arme> Armes { get; set; }
    }
}
