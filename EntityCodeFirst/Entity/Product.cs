using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
   
    public class Product
    {
       
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductMark { get; set; }
        public string ProductCategory { get; set; }
        public int ProductStock { get; set; }
        public string ProductDescription { get; set; }

        public Category Category { get; set; }

    }
}
