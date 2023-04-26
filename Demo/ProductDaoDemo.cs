using OOP_Cong.DAO;
using OOP_Cong.Enity;

namespace OOP_Cong.Demo
{
    public class ProductDaoDemo
    {
        ProductDAO productDAO = new ProductDAO();
        public ProductDaoDemo()
        {
            Console.WriteLine("-----ProductDAO Test------");
        }
        public void InsertTest()
        {
            productDAO.Insert(new Product(1, "San pham", 1));
        }
        public void UpdateTest()
        {
            productDAO.Update(new Product(1, "updated", 1));
        }

        public void DeleteTest()
        {
            productDAO.Update(new Product(1, "updated", 1));
        }
        public void FindByNameTest()
        {
            productDAO.FindByName("updated");
        }
        public void FindByIdTest()
        {
            productDAO.FindById(1);
        }
        public void FindAllTest()
        {
            productDAO.FindAll(new Product(0, "updated", 0));
        }
    }
}
