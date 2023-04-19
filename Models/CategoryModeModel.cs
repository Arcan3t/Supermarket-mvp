using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class CategoryModeModel
    {
        [DisplayName("Category Mode Id")]
        public int Id { get; set; }

        [DisplayName("Category Mode Name")]
        [Required(ErrorMessage = "Category mode name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Category mode name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage = "Category mode observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Category mode observation must be between 3 and 200 characters")]
        public string Observation { get; set; }
    }
}
