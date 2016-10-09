using CafeAlessio.Data.Abstract;
using CafeAlessio.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeAlessio.Domain.Entities;

namespace CafeAlessio.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateUser(UserEntity user)
        {
            _userRepository.Add(user);
        }

        public UserEntity GetUser(int id)
        {
            return _userRepository.GetSingle(id);
        }

        public IEnumerable<UserEntity> GetUsers()
        {
            return _userRepository.GetAll();
        }

        public void SaveUser()
        {
            _userRepository.Commit();
        }
    }
}
