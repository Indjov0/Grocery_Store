using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hranitelen_Magazin.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductTypes { get; set; }

        //1:M
    }
}
