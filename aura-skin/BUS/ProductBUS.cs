using aura_skin.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aura_skin.BUS
{
    internal class ProductBUS
    {
        private ProductsDAO productsDAO=new ProductsDAO();
        public List<Product> products;
        public ProductBUS()
        {
            ReadProductsList();
        }
        public void ReadProductsList()
        {
            this.products=productsDAO.GetProductsList();
        }
        public Product GetProductByID(string id)
        {
            return productsDAO.GetProductByID(id);
        }

        public void UpdateImageProduct(string id, string image)
        {
            Product product=new Product();
            product.id_product= id;
            product.default_image = image;
            productsDAO.UpdateImageProduct(product);
        }
        public void AddProduct(Product product)
        {
            productsDAO.AddProduct(product);
        }
    }
}
