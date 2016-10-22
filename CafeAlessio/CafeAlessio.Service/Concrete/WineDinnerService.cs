using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeAlessio.Data.Abstract;
using CafeAlessio.Domain.Entities;
using CafeAlessio.Service.Abstract;

namespace CafeAlessio.Service.Concrete
{
    public class WineDinnerService : CafeAlessioServiceBase<WineDinnerEntity>, IWineDinnerService
    {
        public WineDinnerService(IRepository<WineDinnerEntity> repository) : base(repository)
        {
        }
    }
}
