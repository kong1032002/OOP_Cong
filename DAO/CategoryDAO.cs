using OOP_Cong.Enity;

namespace OOP_Cong.DAO
{
    internal class CategoryDAO
    {
        private List<Category> categories = Database.Instants.selectTable("CategoryTable").Cast<Category>().ToList();
        public int insert(Category row)
        {
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

        public List<Category> findAll(string name)
        {
            return categories.FindAll(p => p.Name == name);
        }

        public Category findById(int id)
        {
            return categories.Find(p => p.Id == id);
        }
    }
}
