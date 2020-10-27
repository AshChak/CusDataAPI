using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerDataAPI.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required][EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        public DateTime Dob { get; set; }
        [Required]
        public string BillingAddress__StreetAddress { get; set; }
        [Required]
        public string BillingAddress__City { get; set; }
        [Required]
        public string BillingAddress__State { get; set; }
        [Required]
        public string BillingAddress__PostalCode { get; set; }
        [Required]
        public string ShippingAddress__StreetAddress { get; set; }
        [Required]
        public string ShippingAddress__City { get; set; }
        [Required]
        public string ShippingAddress__State { get; set; }
        [Required]
        public string ShippingAddress__PostalCode { get; set; }
        [Phone]
        public string PhoneNumber__Home { get; set; }
        [Required][Phone]
        public string PhoneNumber__Mobile { get; set; }
        [Phone]
        public string PhoneNumber__Fax { get; set; }
    }
}
