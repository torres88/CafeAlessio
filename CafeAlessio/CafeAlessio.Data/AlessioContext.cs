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

        public AlessioContext() : base("CafeAlessio") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>()
            .ToTable("User");
        }

        
    }
}
