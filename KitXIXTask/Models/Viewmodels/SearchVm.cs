using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KitXIXTask.Models.Viewmodels
{
    

    public class SearchViewModel
    {
        public string ProductName { get; set; }
        public string Size { get; set; }
        public decimal? Price { get; set; }
        public DateTime? MfgDate { get; set; }
        public string Category { get; set; }
        public string Condition { get; set; } // AND or OR
        public List<tbl_Product> SearchResults { get; set; }
    }

}