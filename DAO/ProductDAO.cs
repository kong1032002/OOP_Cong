using OOP_Cong.Abtracts;
using OOP_Cong.Enity;

namespace OOP_Cong.DAO
{
    internal class ProductDAO : BaseDAO<Product>
    {
        public ProductDAO()
        {
            Load();
        }
        public void Load()
        {
            data = Database.Instance.SelectTable(Database.PRODUCT_TABLE_NAME).ToList();
        }
        public bool SaveChange()
        {
            return Database.Instance.Save(Database.PRODUCT_TABLE_NAME, data);
        }
    }
}
