using Hranitelen_Magazin.Model;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hranitelen_Magazin.Controller
{
    public class ProductTypeController
    {
        private MagazineDbContext _magazineDbContext = new MagazineDbContext();

        public List<ProductType> GetAllProductTypes()
        {
            return _magazineDbContext.ProductTypes.ToList();
        }

        public string GetProductTypeById(int id)
        {
            return _magazineDbContext.ProductTypes.Find(id).ProductTypeName;
        }
    }
}
