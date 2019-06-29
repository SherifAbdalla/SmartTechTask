using SmartTechTask.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTechTask.Data
{
    public class ProductContext : DbContext
    {

        public ProductContext() : base("SmartTechTaskDB") { }

        public DbSet<Product> Products { get; set; }
    }
}
