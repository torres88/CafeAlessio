using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Domain.Entities
{
    [Table("WineDinner")]
    public class WineDinnerEntity :EntityBase
    {
        public string ShortName { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string ImageName { get; set; }
        public string ImageFile { get; set; }
        public bool Active { get; set; }
    }
}
