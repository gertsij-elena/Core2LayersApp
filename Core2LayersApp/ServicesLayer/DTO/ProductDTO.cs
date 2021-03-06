﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core2LayersApp.Services.DTO
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
       
        public string Description { get; set; }
      
        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public DateTime DeliveryDate { get; set; }
    }
}
