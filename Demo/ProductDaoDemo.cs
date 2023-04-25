using OOP_Cong.DAO;
using OOP_Cong.Enity;

namespace OOP_Cong.Demo
{
    public class ProductDaoDemo
    {
        ProductDAO productDAO = new ProductDAO();
        public ProductDaoDemo() { }
        public void insertTest()
        {
            productDAO.Insert(new Product(1, "San pham", 1));
        }
        public void updateTest()
        {
            productDAO.Update(new Product(1, "updated", 1));
        }

        public void deleteTest()
        {
            productDAO.Update(new Product(1, "updated", 1));
        }
        public void findByNameTest()
        {
            productDAO.FindByName("updated");
        }
        public void findByIdTest()
        {
            productDAO.FindById(1);
        }
        public void findAllTest()
        {
            productDAO.FindAll(new Product(0, "updated", 0));
        }
    }
}
