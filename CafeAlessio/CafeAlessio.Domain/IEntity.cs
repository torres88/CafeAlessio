using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Domain
{
    public interface IEntity
    {
        int Id { get; set; }
        bool Active { get; set; }
        DateTime CreationDate { get; set; }
        string CreatedBy { get; set; }
        DateTime ModificationDate { get; set; }
        string ModifiedBy { get; set; }
    }
}
