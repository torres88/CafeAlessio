using CafeAlessio.Data.Abstract;
using CafeAlessio.Domain.Entities;
using CafeAlessio.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Service.Concrete
{
    public class ProductService : CafeAlessioServiceBase<ProductTypeEntity>, IProductService
    {
        public ProductService(IRepository<ProductTypeEntity> repository)
            : base(repository)
        {
        }

        
    }
}
