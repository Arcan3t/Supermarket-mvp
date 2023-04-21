using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class ProductModel
    {
        [DisplayName("Product Id")]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage = "Product observation is required")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Product observation must be between 3 and 10 characters")]
        public int Price { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage = "Product observation is required")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Product observation must be between 1 and 10 characters")]
        public int Stock { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage = "Product observation is required")]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "Product observation must be between 6 and 100 characters")]
        public int Category { get; set; }
    }
}
