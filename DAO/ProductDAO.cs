using OOP_Cong.Abtracts;
using OOP_Cong.Enity;

namespace OOP_Cong.DAO
{
    internal class ProductDAO : BaseDAO<Product>
    {
        private static List<Product> products = Database.Instance.SelectTable(Database.ProductTableName).Cast<Product>().ToList();
        public ProductDAO() { }
        public override int Insert(Product row)
        {
            return Database.Instance.InsertTable(Database.ProductTableName, row);
        }

        public override int Update(Product row)
        {
            Database.Instance.UpdateTable(Database.ProductTableName, row);
            Load();
            return 0;
        }

        public override bool Delete(Product row)
        {
            bool isSuccess = Database.Instance.DeleteTable(Database.ProductTableName, row);
            if (isSuccess)
            {
                Load();
            }
            return isSuccess;
        }

        public override List<Product> FindAll(Product row)
        {
            return products.FindAll(p => p.Name == row.Name);
        }
        public override Product FindById(int id)
        {
            return products.Find(p => p.Id == id);
        }

        public override Product FindByName(string name)
        {
            return products.Find(p => p.Name == name);
        }
        public override void Load()
        {
            products = Database.Instance.SelectTable(Database.ProductTableName).Cast<Product>().ToList();
        }
    }
}
