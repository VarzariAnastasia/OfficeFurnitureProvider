using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OfficeFurnitureProviderApp.Models
{
    public class ShopNowModel
    {
        [Display(Name = "Customer")]
        public string Customer { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }        

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Total Price")]
        public float TotalPrice { get; set; }
    }
}
