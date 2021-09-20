using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OfficeFurnitureProviderApp.Models
{
    public class ProductModel
    {
        [Display(Name = "Product ID")]
        [Range(100, 999, ErrorMessage = "Enter a valid ID")]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Display(Name = "Price")]
        public float Price { get; set; }

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

    }
}