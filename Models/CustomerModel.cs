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
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Customer document must be 10 characters")]
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
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customer birthday the format must be between 0001-01-01 and 9999-12-31")]
        public DateOnly Birthday { get; set; }

        [DisplayName("Customer Phone Number")]
        [Required(ErrorMessage = "Customer phone number is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customer phone number the format must be 10 digits")]
        public long PhoneNumber { get; set; }

        [DisplayName("Customer Email")]
        [Required(ErrorMessage = "Customer emial is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customer address must be between 3 and 100 characters")]
        public string Email { get; set; }
    }
}
