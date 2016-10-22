using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeAlessio.Data.Abstract;
using CafeAlessio.Domain.Entities;

namespace CafeAlessio.Data.Repositories
{
    public class WineDinnerRepository : RepositoryBase<WineDinnerEntity>, IWineDinnerRepository
    {
        public WineDinnerRepository(AlessioContext context) : base(context) { }
    }
}
