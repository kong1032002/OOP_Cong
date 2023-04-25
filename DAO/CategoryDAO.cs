using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using OOP_Cong.Enity;

namespace OOP_Cong.DAO
{
    internal class CategoryDAO
    {
        List<Category> categories = Database.Instants.selectTable("CategoryTable").Cast<Category>().ToList();
        public int insert(Category row) {
            Database.Instants.insertTable("categoryTable", row);
            return 0;
        }
        public int update(Category row)
        {
            Database.Instants.updateTable("categoryTable", row);
            return 0;
        }
        public bool delete(int id)
        {
            Database.Instants.deleteTable("categoryTable", id);
            return false;
        }

        public List<Category> findAll(string name) { 
            List<Category> result = new List<Category>();
            foreach (Category category in Database.Instants.selectTable("categoryTable"))
            {
                if (category.Name == name) 
                    result.Add(category);
            }
            return result;
        }

        public Object findById(int id)
        {
            foreach(Category category in Database.Instants.selectTable("categoryTable"))
            {
                if (category.Id == id) return category;
            }
            return null;
        }
    }
}
