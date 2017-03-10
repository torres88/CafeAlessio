using CafeAlessio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Data
{
    public class AlessioInitializer : DropCreateDatabaseIfModelChanges<AlessioContext>
    {
        protected override void Seed(AlessioContext context)
        {
            var users = new List<UserEntity>()
            {
                new UserEntity() { Id = 1, Firstname = "Balázs",Lastname="Tordai" },
                new UserEntity() { Id = 2, Firstname = "Réka",Lastname="Tordai" }
            };

            users.ForEach(x => context.Users.Add(x));

            var productTypes = new List<ProductTypeEntity>()
            {
                new ProductTypeEntity() { Id= 1, NameHUN = "Termékcsoport 1" },
                new ProductTypeEntity() { Id= 2,NameHUN ="Termékcsoport 2" },
                new ProductTypeEntity() { Id= 3,NameHUN ="Termékcsoport 3" }
            };

            var products = new List<ProductEntity>()
            {
                new ProductEntity() {
                        Id =1,
                    DescriptionHun ="Termék leírása",ImageName = "Kép neve", IsSpicy = true, IsVega = true, Measure = MeasureEnum.dl, Price = 250.05M, ProductType = productTypes[0],ProductTypeId = 1,Unit = 1}
            };
        }
    }
}
