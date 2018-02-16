using System;
using System.Collections.Generic;


namespace Core2LayersApp.Services.DTO
{
    public class ProductTypeCategoryDTO
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string TypeDescription { get; set; }
        public int CountCategory { get; set; }

    }
}
