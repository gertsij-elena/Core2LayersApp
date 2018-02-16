using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Core2LayersApp.DAL.Entities
{
    public class Type
    {
        [Key]
        [ScaffoldColumn(false)]
        public int TypeId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "required")]
        [StringLength(50, ErrorMessage = "not more than 50 symbols")]
        public string Name { get; set; }

        [Display(Name = "Type Description")]
        [Required(ErrorMessage = "required")]
        [StringLength(50, ErrorMessage = "not more than 50 symbols")]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
