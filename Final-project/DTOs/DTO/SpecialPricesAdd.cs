﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.DTO
{
    public class SpecialPricesAdd
    {
        public decimal Price { get; set; }
        public int GovernorateId { get; set; }
        public int CityId { get; set; }
    }
}
