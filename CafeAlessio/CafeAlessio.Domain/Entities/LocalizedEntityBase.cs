using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Domain.Entities
{
    public class LocalizedEntityBase : EntityBase, IEntity
    {
        [Required]
        public string NameHUN { get; set; }

        public string NameENG { get; set; }
        public string NameITA { get; set; }
    }
}
