using OOP_Cong.DAO;
using OOP_Cong.Enity;

namespace OOP_Cong.Demo
{
    internal class CategoryDaoDemo
    {
        CategoryDAO categoryDAO = new CategoryDAO();
        public CategoryDaoDemo()
        {
            Console.WriteLine("\n-----CategoryDAO Test------");
        }

        public void Init()
        {
            InsertTest();
            Console.WriteLine("       Before");
            categoryDAO.PrintAll();
            UpdateTest();
            DeleteTest();
            Console.WriteLine("       After");
            categoryDAO.PrintAll();
            FindAllTest();
            FindByNameTest();
            FindByIdTest();
        }
        public void InsertTest()
        {
            categoryDAO.Insert(new Category(1, "Co vua"));
            categoryDAO.Insert(new Category(2, "Co tuong"));
            categoryDAO.Insert(new Category(3, "Co ca ngua"));
            categoryDAO.Insert(new Category(4, "Co vay"));
            categoryDAO.Insert(new Category(5, "Mat chuoc"));
            categoryDAO.Insert(new Category(6, "Shogi"));
            categoryDAO.Insert(new Category(7, "Tu lo kho"));
            categoryDAO.Insert(new Category(8, "Tu lo kho"));
        }

        public void UpdateTest()
        {
            categoryDAO.Update(new Category(1, "Updated - CoVua"));
            categoryDAO.Update(new Category(2, "Updated - CoTuong"));
            categoryDAO.Update(new Category(3, "Updated - CoCaNgua"));
            categoryDAO.Update(new Category(4, "Updated - CoVay"));
            categoryDAO.Update(new Category(5, "Updated - MatChuoc"));
            categoryDAO.SaveChange();
            categoryDAO.Load();
        }
        public void DeleteTest()
        {
            categoryDAO.Delete(new Category(6, "Shogi"));
            categoryDAO.SaveChange();
            categoryDAO.Load();
        }
        public void FindAllTest()
        {
            Console.WriteLine("FindAll Test");
            List<Category> categories = categoryDAO.FindAll(new Category(6, "Tu lo kho"));
            foreach (Category category in categories)
            {
                Console.WriteLine(category);
            }
        }

        public void FindByNameTest()
        {
            Console.WriteLine("FindByName Test");
            Category category = categoryDAO.FindByName("Updated - CoVay");
            Category category1 = categoryDAO.FindByName("Updated - CoVua");
            Category category2 = categoryDAO.FindByName("Co vua");
            Category category3 = categoryDAO.FindByName("Co tuong");
            Console.WriteLine("{0}, {1}, {2}, {3}", category, category1, category2, category3);
        }

        public void FindByIdTest()
        {
            Console.WriteLine("FindById Test");
            Category category = categoryDAO.FindById(1);
            Console.WriteLine(category);
        }
    }
}
