using CafeAlessio.Data.Abstract;
using CafeAlessio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Data.Repositories
{
    public class DailyOfferRepository : RepositoryBase<DailyOfferItemEntity>, IDailyOfferRepository
    {
        public DailyOfferRepository(AlessioContext context) : base(context) { }

        public override IEnumerable<DailyOfferItemEntity> GetAll()
        {
            return this.AllIncluding()
            .OrderBy(dailyOffer => dailyOffer.Index);
            //.ThenBy(answer => answer.Text);
        }

    }
}
