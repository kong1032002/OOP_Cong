using OOP_Cong.DAO;
using OOP_Cong.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cong.Demo
{
    public class ProductDaoDemo
    {
        ProductDAO productDAO = new ProductDAO();

        public ProductDaoDemo()
        {
        }

        public void insertTest()
        {
            productDAO.insert(new Product(1, "San pham", 1));
        }
        public void updateTest()
        {
            productDAO.update(new Product(1, "updated", 1));
        }

        public void deleteTest()
        {
            productDAO.update(new Product(1, "updated", 1));
        }
        public void findByNameTest()
        {
            productDAO.findByName("updated");
        }
        public void findByIdTest()
        {
            productDAO.findById(1);
        }
        public void findAllTest()
        {
            productDAO.findAll("updated");
        }
    }
}
