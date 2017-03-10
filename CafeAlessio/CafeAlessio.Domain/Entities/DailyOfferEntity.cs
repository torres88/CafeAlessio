using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Domain.Entities
{
    [Table("DailyOffer")]
    public class DailyOfferEntity : LocalizedEntityBase
    {
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Index { get; set; }
    }
}
