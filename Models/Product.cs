﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hafta2.Models
{
    public class Product
    {
        public Guid? Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public double Price { get; set; }
    }
}
