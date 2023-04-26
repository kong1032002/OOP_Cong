using OOP_Cong.DAO;
using OOP_Cong.Enity;

namespace OOP_Cong.Demo
{
    public class ProductDaoDemo
    {
        ProductDAO productDAO = new ProductDAO();
        public ProductDaoDemo()
        {
            Console.WriteLine("\n-----ProductDAO Test------");
        }
        public void Init()
        {
            InsertTest();
            Console.WriteLine("       Before");
            productDAO.PrintAll();
            UpdateTest();
            DeleteTest();
            Console.WriteLine("       After");
            productDAO.PrintAll();
            FindAllTest();
            FindByNameTest();
            FindByIdTest();
        }
        public void InsertTest()
        {
            productDAO.Insert(new Product(1, "Vua", 1));
            productDAO.Insert(new Product(2, "Hau", 1));
            productDAO.Insert(new Product(3, "Xe", 1));
            productDAO.Insert(new Product(4, "Tinh", 1));
            productDAO.Insert(new Product(5, "Ma", 1));
            productDAO.Insert(new Product(6, "Tot", 1));
            productDAO.Insert(new Product(7, "Tuong", 2));
            productDAO.Insert(new Product(8, "Si", 2));
            productDAO.Insert(new Product(9, "Si", 2));
            productDAO.Insert(new Product(10, "Si", 2));
        }

        public void UpdateTest()
        {
            productDAO.Update(new Product(1, "Updated - King", 1));
            productDAO.Update(new Product(2, "Updated - Queen", 1));
            productDAO.Update(new Product(3, "Updated - Rook", 1));
            productDAO.Update(new Product(4, "Updated - Bishop", 1));
            productDAO.Update(new Product(5, "Updated - Knight", 1));
        }
        public void DeleteTest()
        {
            productDAO.Delete(new Product(10, "Si", 2));
        }
        public void FindAllTest()
        {
            Console.WriteLine("FindAll Test");
            List<Product> products = productDAO.FindAll(new Product(1, "Si", 2));
            foreach (Product accessory in products)
            {
                Console.WriteLine(accessory);
            }
        }

        public void FindByNameTest()
        {
            Console.WriteLine("FindByName Test");
            Product accessory = productDAO.FindByName("Updated - King");
            Product accessory1 = productDAO.FindByName("Updated - Queen");
            Product accessory2 = productDAO.FindByName("Vua");
            Product accessory3 = productDAO.FindByName("Hau");
            Console.WriteLine("{0}, {1}, {2}, {3}", accessory, accessory1, accessory2, accessory3);
        }

        public void FindByIdTest()
        {
            Console.WriteLine("FindById Test");
            Product accessory = productDAO.FindById(1);
            Console.WriteLine(accessory);
        }
    }
}
