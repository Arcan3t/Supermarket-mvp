using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class CustomerModel
    {
        [DisplayName("Customer Id")]
        public int Id { get; set; }

        [DisplayName("Customer Document Number")]
        [Required(ErrorMessage = "Customer document number is required")]
        public int DocumentNumber { get; set; }

        [DisplayName("Customer First Name")]
        [Required(ErrorMessage = "Customer first name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customer first name must be between 3 and 50 characters")]
        public string FirstName { get; set; }

        [DisplayName("Customer Last Name")]
        [Required(ErrorMessage = "Customer last name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customer last name must be between 3 and 50 characters")]
        public string LastName { get; set; }

        [DisplayName("Customer Address")]
        [Required(ErrorMessage = "Customer address is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customer address must be between 3 and 50 characters")]
        public string Address { get; set; }

        [DisplayName("Customer Birthday")]
        [Required(ErrorMessage = "Customer birthday is required")]
        public DateTime Birthday { get; set; }

        [DisplayName("Customer Phone Number")]
        [Required(ErrorMessage = "Customer phone number is required")]
        public long PhoneNumber { get; set; }

        [DisplayName("Customer Email")]
        [Required(ErrorMessage = "Customer emial is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customer address must be between 3 and 100 characters")]
        public string Email { get; set; }
    }
}
