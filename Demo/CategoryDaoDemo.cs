using OOP_Cong.DAO;
using OOP_Cong.Enity;

namespace OOP_Cong.Demo
{
    internal class CategoryDaoDemo
    {
        CategoryDAO category = new CategoryDAO();
        public void insertTest()
        {
            category.Insert(new Category());
        }
        public void updateTest()
        {
            category.Update(new Category(-1, "Dien thoai"));
        }
        public void deleteTest()
        {
            category.Delete(new Category(-1, "Dien thoai"));
        }
        public void findAll()
        {
            category.FindAll(new Category(-1, "Dien thoai"));
        }
        public void findById()
        {
            category.FindById(-1);
        }
    }
}
