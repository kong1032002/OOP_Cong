using OOP_Cong.Abtracts;
using OOP_Cong.Enity;

namespace OOP_Cong.DAO
{
    internal class CategoryDAO : BaseDAO<Category>
    {
        private static List<Category> categories = Database.Instance.SelectTable(Database.CategoryTableName).Cast<Category>().ToList();
        public CategoryDAO() { }
        public override int Insert(Category row)
        {
            return Database.Instance.InsertTable(Database.CategoryTableName, row);
        }
        public override int Update(Category row)
        {
            Load();
            return Database.Instance.UpdateTable(Database.CategoryTableName, row);
        }
        public override bool Delete(Category row)
        {
            bool isSuccess = Database.Instance.DeleteTable(Database.CategoryTableName, row);
            Load();
            return isSuccess;
        }

        public override List<Category> FindAll(Category row)
        {
            return categories.FindAll(p => p.Name == row.Name);
        }

        public override Category FindById(int id)
        {
            return categories.Find(p => p.Id == id);
        }
        public override Category FindByName(string name)
        {
            return categories.Find(p => p.Name == name);
        }
        public override void Load()
        {
            categories = Database.Instance.SelectTable(Database.CategoryTableName).Cast<Category>().ToList();
        }
    }
}
