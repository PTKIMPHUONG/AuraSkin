using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aura_skin.DAO
{
    internal class CategoriesDAO
    {
        Database_AuraSkinDataContext db = new Database_AuraSkinDataContext();
        public List<Category> GetCategoriesList()
        {
            return db.Categories.ToList();
        }
        public Category GetCategorytByID(string id)
        {
            return db.Categories.FirstOrDefault(l => l.id_category == id);
        }
    }
}
