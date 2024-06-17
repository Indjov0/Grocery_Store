using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hranitelen_Magazin.Model
{
    public class ProductType
    {

        public int Id { get; set; }//FK
        public string ProductTypeName { get; set; }
        public ICollection<Product> Products { get; set; }


        //M:1

    }
}
