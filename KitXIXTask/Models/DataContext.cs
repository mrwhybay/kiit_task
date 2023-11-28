using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KitXIXTask.Models
{
    public class DataDbContext : DbContext
    {
        public DbSet<tbl_Product> tbl_Products  { get; set; }
    }
}