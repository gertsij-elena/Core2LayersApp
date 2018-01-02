using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

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

        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "Поле обязательно")]
        public int  Quantity { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Поле обязательно")]
        public decimal Price { get; set; }

        [Display(Name = "IsAvailable")]
        [Required(ErrorMessage = "Поле обязательно")]
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
