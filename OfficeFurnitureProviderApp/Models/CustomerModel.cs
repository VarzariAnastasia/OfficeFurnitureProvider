using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OfficeFurnitureProviderApp.Models
{
    public class CustomerModel
    {
        [Display(Name = "Customer ID")]
        [Range(100000, 999999, ErrorMessage = "Enter a valid ID")]
        public int CustomerId { get; set; }

        [Display(Name = "Customer Name")]
        public string Name { get; set; }

        [Display(Name = "Customer Rebate")]
        public int Rebate { get; set; } 
    
    }
}