using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MvcDataBinding.Models
{
    [Table("tblProducts")]
    public class Product
    { 
        [Key]
        public int ProductID { get; set;}
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }
    }
}
