using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core2LayersApp.DAL.Entities
{
    class Product
    {

        [Key]
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }

        [Display(Name = "Product")]
        [Required(ErrorMessage = "Поле обязательно")]
        [StringLength(50, ErrorMessage = "Длина не должна превышать 50 символов")]
        public string Description { get; set; }
        public int  Quantity { get; set; }

        public int TypeId { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }

        public Product()
        {
            ProductCategories = new List<ProductCategory>();
        }
    }
}
