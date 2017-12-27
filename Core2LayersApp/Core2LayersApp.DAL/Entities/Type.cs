using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core2LayersApp.DAL.Entities
{
    class Type
    {
        [Key]
        [ScaffoldColumn(false)]
        public int TypeId { get; set; }

        [Display(Name = "Type Description")]
        [Required(ErrorMessage = "Поле обязательно")]
        [StringLength(50, ErrorMessage = "Длина не должна превышать 50 символов")]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
