﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApiClient.Model.Product
{
    public class ProductUpdateReq
    {
        public string Id { get; set; }   = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
    }
}
