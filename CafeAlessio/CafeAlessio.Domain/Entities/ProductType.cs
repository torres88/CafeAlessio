﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAlessio.Domain.Entities
{
    public class ProductType : EntityBase
    {
        public string Name { get; set; }
        public ProductType SubProductType { get; set; }
    }
}
