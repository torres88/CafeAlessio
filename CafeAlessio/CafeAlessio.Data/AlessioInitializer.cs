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
        }
    }
}
