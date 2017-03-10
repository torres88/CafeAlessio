using CafeAlessio.Data.Abstract;
using CafeAlessio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Data.Repositories
{
    public class ProductRepository : RepositoryBase<ProductEntity>, IProductRepository
    {
        public ProductRepository(AlessioContext context) : base(context) { }

        public override IEnumerable<ProductEntity> GetAll()
        {
            return this.AllIncluding(product => product.ProductType);
                                        //.OrderBy(product => product.)
                                        //.ThenBy(answer => answer.Text);
        }

    }
}
