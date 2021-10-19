using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace timan.models
{
    public class ProductList
    {
      [Key]  public int ProductID { get; set; }
        [Required]
        [MinLength(2)]
        public string ProductName { get; set; }
        public string Price { get; set; }
        public  int CategoryID { get; set; }
        public string Photo { get; set; }
        public string Desc1 { get; set; }
        public string Desc2 { get; set; }
        public string Desc3 { get; set; }

        public string Desc4 { get; set; }
        public string Status { get; set; }

        public int Sold { get; set; }
        public int Rate { get; set; }
      //  public int category_Id { get; set; }
        public Category Category { get; set; }
        public bool Any()
        {
            throw new NotImplementedException();
        }
    }
}
