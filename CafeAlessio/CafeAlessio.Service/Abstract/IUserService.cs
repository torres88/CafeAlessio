﻿using CafeAlessio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Service.Abstract
{
    public interface IUserService
    {
        IEnumerable<UserEntity> GetUsers();
        UserEntity GetUser(int id);
        void CreateUser(UserEntity user);
        void SaveUser();
    }
}
