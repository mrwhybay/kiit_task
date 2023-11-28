using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KitXIXTask.Models
{
    public class tbl_Product
    {
        [Key]
        [Display(Name = "ID")]
        public int ProductId { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Display(Name = "Size")]
        public string Size { get; set; }
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [Display(Name = "Manufacturing Date")]
        public DateTime MfgDate { get; set; }
        [Display(Name = "Category")]
        public string Category { get; set; }
    }
}