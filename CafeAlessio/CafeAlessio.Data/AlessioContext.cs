using CafeAlessio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Data
{
    public class AlessioContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ProductTypeEntity> ProductType { get; set; }
        public DbSet<ProductGroupEntity> ProductGroup { get; set; }
        public DbSet<WineDinnerEntity> WineDinner { get; set; }
        public DbSet<SiteMenuEntity> SiteMenu { get; set; }
        public DbSet<DailyOfferItemEntity> DailyOffer { get; set; }

        public AlessioContext() : base("CafeAlessio") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<UserEntity>()
            //.ToTable("User");

            //modelBuilder.Entity<ProductEntity>()
            //    .HasRequired(ProductTypeEntity);
        }

        
    }
}
