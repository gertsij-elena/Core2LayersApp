using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core2LayersApp.DAL.Entities
{
    class Category
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CategoryId { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Поле обязательно")]
        [StringLength(50, ErrorMessage = "Длина не должна превышать 50 символов")]
        public string Description { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }

        public Category()
        {
            ProductCategories = new List<ProductCategory>();
        }

    }
}
