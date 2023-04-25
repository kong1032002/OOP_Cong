using OOP_Cong.Abtracts;
using OOP_Cong.Enity;
using OOP_Cong.Interface;

namespace OOP_Cong.DAO
{
    internal class ProductDAO : BaseDAO<Product>, IDao<Product>
    {
        public ProductDAO()
        {
            data = Database.Instance.SelectTable(Database.ProductTableName).Cast<Product>().ToList();
        }
        public int Insert(Product row)
        {
            return Database.Instance.InsertTable(Database.ProductTableName, row);
        }

        public int Update(Product row)
        {
            Database.Instance.UpdateTable(Database.ProductTableName, row);
            Load();
            return 0;
        }
        public bool Delete(Product row)
        {
            bool isSuccess = Database.Instance.DeleteTable(Database.ProductTableName, row);
            if (isSuccess)
            {
                Load();
            }
            return isSuccess;
        }
        public List<Product> FindAll(Product row)
        {
            return data.FindAll(p => p.Name == row.Name);
        }
        public Product FindById(int id)
        {
            return data.Find(p => p.Id == id);
        }
        public Product FindByName(string name)
        {
            return data.Find(p => p.Name == name);
        }
        public void Load()
        {
            data = Database.Instance.SelectTable(Database.ProductTableName).Cast<Product>().ToList();
        }
    }
}
