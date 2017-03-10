﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Domain.Entities
{
    [Table("Wine")]
    public class Wines : EntityBase
    {
        public string Name { get; set; }
    }
}
