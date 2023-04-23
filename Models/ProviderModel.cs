using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class ProviderModel
    {
        [DisplayName("Provider Id")]
        public int Id { get; set; }

        [DisplayName("Provider Name")]
        [Required(ErrorMessage = "Provider name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Provider name must be between 3 and 50 characters")]
        public string Name { get; set; }
    }
}
