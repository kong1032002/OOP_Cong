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
        public int insert(Category row) {
            Database.instants.InsertTable("categoryTable", row);
            return 0;
        }
        public int update(Category row)
        {
            Database.instants.UpdateTable("categoryTable", row);
            return 0;
        }
        public bool delete(int id)
        {
            Database.instants.DeleteTable("categoryTable", id);
            return false;
        }

        public List<Category> findAll(string name) { 
            List<Category> result = new List<Category>();
            Database.instants.SelectTable("categoryTable");
            foreach (Category category in Database.instants.SelectTable("categoryTable"))
            {
                if (category.name == name) 
                    result.Add(category);
            }
            return result;
        }

        public Object findById(int id)
        {
            foreach(Category category in Database.instants.SelectTable("categoryTable"))
            {
                if (category.id == id) return category;
            }
            return null;
        }
    }
}
