using OOP_Cong.Abtracts;
using OOP_Cong.Enity;
using OOP_Cong.Interface;

namespace OOP_Cong.DAO
{
    internal class CategoryDAO : BaseDAO<Category>, IDao<Category>
    {
        public CategoryDAO()
        {
            data = Database.Instance.SelectTable(Database.CategoryTableName).Cast<Category>().ToList();
        }
        public int Insert(Category row)
        {
            return Database.Instance.InsertTable(Database.CategoryTableName, row);
        }
        public int Update(Category row)
        {
            Load();
            return Database.Instance.UpdateTable(Database.CategoryTableName, row);
        }
        public bool Delete(Category row)
        {
            bool isSuccess = Database.Instance.DeleteTable(Database.CategoryTableName, row);
            Load();
            return isSuccess;
        }
        public List<Category> FindAll(Category row)
        {
            return data.FindAll(p => p.Name == row.Name);
        }
        public Category FindById(int id)
        {
            return data.Find(p => p.Id == id);
        }
        public Category FindByName(string name)
        {
            return data.Find(p => p.Name == name);
        }
        public void Load()
        {
            data = Database.Instance.SelectTable(Database.CategoryTableName).Cast<Category>().ToList();
        }
    }
}
