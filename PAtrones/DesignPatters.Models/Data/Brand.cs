﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DesignPatters.Models.Data
{
    public partial class Brand
    {
        public Brand()
        {
            Beers = new HashSet<Beer>();
        }

        public Guid BrandId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Beer> Beers { get; set; }
    }
}
