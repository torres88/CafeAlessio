using CafeAlessio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Data.Abstract
{
    public interface IUserRepository : IEntityBaseRepository<UserEntity>
    {
    }
}
