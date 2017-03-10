using CafeAlessio.Data.Abstract;
using CafeAlessio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Data.Repositories
{
    public class ProductTypeRepository : RepositoryBase<ProductTypeEntity>, IProductTypeRepository
    {
        public ProductTypeRepository(AlessioContext context) : base(context) { }        
    }
}
