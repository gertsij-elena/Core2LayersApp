using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Core2LayersApp.DAL.Entities
{
    public  class Product
    {

        [Key]
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }

        [Display(Name = "Product")]
        [Required(ErrorMessage = "required")]
        [StringLength(50, ErrorMessage = "not more than 50 symbols")]
        public string Description { get; set; }

        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "required")]
        public int  Quantity { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "required")]
        public decimal Price { get; set; }

        [Display(Name = "IsAvailable")]
        [Required(ErrorMessage = "required")]
        public bool IsAvailable { get; set; }

        [Display(Name = "DeliveryDate")]
        [Required(ErrorMessage = "Поле обязательно")]
        public DateTime DeliveryDate { get; set; }

        public int TypeId { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }

        public Product()
        {
            ProductCategories = new List<ProductCategory>();
        }
    }
}
