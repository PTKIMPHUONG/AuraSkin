using aura_skin.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aura_skin.BUS
{
    internal class CategoriesBUS
    {
        private CategoriesDAO categoriesDAO = new CategoriesDAO();
        public List<Category> categories;
        public CategoriesBUS()
        {
            ReadCatgegoriesList();
        }
        public void ReadCatgegoriesList()
        {
            this.categories = categoriesDAO.GetCategoriesList();
        }
        public Category GetCategoryByID(string id)
        {
            return categoriesDAO.GetCategorytByID(id);
        }
    }
}
