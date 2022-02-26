using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatterDesigns.Models.ViewModels
{
    public class FormBeerViewModel
    {
        [Display(Name = "Otra Marca")]
        public string OtherBrand { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Estilo")]
        public string Style { get; set; }

        [Display(Name = "Marca")]
        public Guid? BrandId { get; set; }
    }
}
