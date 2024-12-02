using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aura_skin.DAO
{
    internal class ProductsDAO
    {
        Database_AuraSkinDataContext db = new Database_AuraSkinDataContext();
        public List<Product> GetProductsList()
        {
            return db.Products.ToList();
        }
        public Product GetProductByID(string id)
        {
            return db.Products.FirstOrDefault(l => l.id_product == id);
        }
        public void UpdateImageProduct(Product product)
        {
            var prd = db.Products.FirstOrDefault(l => l.id_product == product.id_product);
            prd.default_image = product.default_image;
            db.SubmitChanges();
        }
    }
}
