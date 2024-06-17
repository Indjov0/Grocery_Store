using Hranitelen_Magazin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hranitelen_Magazin.Controller
{
    public class ProductController
    {
        private MagazineDbContext _magazineDbContext = new MagazineDbContext(); 

        public Product Get(int id)
        {
            Product findedProduct = _magazineDbContext.Products.Find(id);
            if (findedProduct != null)
            {
                _magazineDbContext.Entry(findedProduct).Reference(x => x.ProductTypes).Load();
            }
            return findedProduct;
        }
        public List<Product> GetAll()
        {
            return _magazineDbContext.Products.Include("ProductTypes").ToList();
        }

        public void Create(Product product)
        {
            _magazineDbContext.Products.Add(product);
            _magazineDbContext.SaveChanges();
        }
        public void Update(int id, Product product)
        {
            Product findedProduct = _magazineDbContext.Products.Find(id);
            if (findedProduct == null)
            {
                return;
            }
            findedProduct.Brand = product.Brand;
            findedProduct.Description = product.Description;
            findedProduct.Price = product.Price;
            findedProduct.ExpirationDate = product.ExpirationDate;
            //findedProduct.ProductTypes.ProductTypeName  = product.ProductTypes.ProductTypeName;
            findedProduct.ProductTypeId = product.ProductTypeId;

            _magazineDbContext.SaveChanges();
        
        }
        public void Delete(int id)
        {
            Product findedProduct = _magazineDbContext.Products.Find(id);
            _magazineDbContext.Products.Remove(findedProduct);
            _magazineDbContext.SaveChanges();
        }
    }
}
