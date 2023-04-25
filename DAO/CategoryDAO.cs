using OOP_Cong.Enity;

namespace OOP_Cong.DAO
{
    internal class CategoryDAO
    {
        private static List<Category> categories = Database.Instants.selectTable(Database.productTableName).Cast<Category>().ToList();
        public CategoryDAO()
        {

        }
        public int insert(Category row)
        {
            Database.Instants.insertTable(Database.categoryTableName, row);
            return 0;
        }
        public int update(Category row)
        {
            Database.Instants.updateTable(Database.productTableName, row);
            return 0;
        }
        public bool delete(int id)
        {
            Database.Instants.deleteTable(Database.productTableName, id);
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
