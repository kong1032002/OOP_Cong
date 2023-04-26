using OOP_Cong.Abtracts;
using OOP_Cong.Enity;

namespace OOP_Cong.DAO
{
    internal class CategoryDAO : BaseDAO<Category>
    {
        public CategoryDAO()
        {
            Load();
        }
        public void Load()
        {
            data = Database.Instance.SelectTable(Database.CATEGORY_TABLE_NAME).ToList();
        }
        public bool SaveChange()
        {
            return Database.Instance.Save(Database.CATEGORY_TABLE_NAME, data);
        }
    }
}
