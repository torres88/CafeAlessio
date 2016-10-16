using CafeAlessio.Data.Abstract;
using CafeAlessio.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeAlessio.Domain.Entities;
using CafeAlessio.Service.Concrete;

namespace CafeAlessio.Service.Concrete
{
    public class UserService : CafeAlessioServiceBase<UserEntity>, IUserService
    {
        public UserService(IRepository<UserEntity> repository)
            : base(repository)
        {
        }


        
    }
}
