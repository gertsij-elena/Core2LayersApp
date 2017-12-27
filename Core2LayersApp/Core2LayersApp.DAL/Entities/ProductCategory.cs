using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core2LayersApp.DAL.Entities
{
    class ProductCategory
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public string CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
