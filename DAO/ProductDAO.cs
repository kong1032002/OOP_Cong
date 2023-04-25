using OOP_Cong.Enity;

namespace OOP_Cong.DAO
{
    internal class ProductDAO
    {
        private List<Product> products = Database.Instants.selectTable("ProductTable").Cast<Product>().ToList();
        public ProductDAO() { }
        public int insert(Product row)
        {
            Database.Instants.insertTable("ProductTable", row);
            return 0;
        }

        public int update(Product row)
        {
            Database.Instants.updateTable("ProductTable", row);
            return 0;
        }

        public bool delete(int row)
        {
            Database.Instants.deleteTable("ProductTable", row);
            return false;
        }

        public List<Product> findAll(string name)
        {
            return products.FindAll(p => p.Name == name);
        }
        public Product findById(int id)
        {
            return products.Find(p => p.Id == id);

        }

        public Product findByName(string name)
        {
            return products.Find(p => p.Name == name);

        }
    }
}
