using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MvcDataBinding.Models
{
    class ProductsContext : DbContext
    {
        public ProductsContext():base("ProductsConnection")
        {

        }
        public DbSet<Product> ProductsTable { get; set; }
    }
}
