using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OfficeFurnitureProviderApp.Models
{
    public class ViewOrderModel
    {
        [Display(Name = "Order")]
        public string Order { get; set; }

        [Display(Name = "Total Price")]
        public float TotalPrice { get; set; }
    }
}