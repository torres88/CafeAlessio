﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Domain.Entities
{
    public class EntityBase : IEntity
    {
        public int Id { get; set; }
    }
}
