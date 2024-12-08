using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aura_skin.DAO;

namespace aura_skin.BUS
{
    public class RecommendationsBUS
    {
        private OrdersDAO ordersDAO = new OrdersDAO();
        private ProductsDAO productsDAO = new ProductsDAO();

        // Gợi ý sản phẩm bằng Collaborative Filtering
        public List<Product> RecommendProductsByCollaborativeFiltering(string customerID)
        {
            var customerProducts = ordersDAO.GetCustomerProductIDs(customerID);
            var productFrequency = ordersDAO.GetProductPurchaseFrequency();

            var recommendedProducts = productFrequency
                .Where(p => !customerProducts.Contains(p.Key))
                .OrderByDescending(p => p.Value) // Sắp xếp theo tần suất mua
                .Select(p => productsDAO.GetProductByID(p.Key))
                .ToList();

            return recommendedProducts;
        }

        // Gợi ý sản phẩm bằng Cosine Similarity
        public List<Product> RecommendProductsByCosineSimilarity(string customerID)
        {
            var customerProducts = ordersDAO.GetCustomerProductIDs(customerID);
            var allProducts = productsDAO.GetProductsList();

            // Tính Cosine Similarity
            var recommendedProducts = new List<Product>();
            foreach (var product in allProducts)
            {
                if (!customerProducts.Contains(product.id_product))
                {
                    double similarity = CalculateCosineSimilarity(customerProducts, product.id_product);
                    if (similarity > 0.5) 
                    {
                        recommendedProducts.Add(product);
                    }
                }
            }

            return recommendedProducts;
        }

        private double CalculateCosineSimilarity(List<string> customerProducts, string productID)
        {
            return new Random().NextDouble(); 
        }
    }
}
