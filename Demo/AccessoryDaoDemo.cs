using OOP_Cong.DAO;
using OOP_Cong.Enity;

namespace OOP_Cong.Demo
{
    internal class AccessoryDaoDemo
    {
        AccessoryDAO accessoryDao = new AccessoryDAO();
        public AccessoryDaoDemo()
        {
            Console.WriteLine("-----AccessoryDAO Test------");
        }

        public void Init()
        {
            InsertTest();
            Console.WriteLine("Before");
            accessoryDao.PrintAll();
            UpdateTest();
            DeleteTest();
            Console.WriteLine("After");
            accessoryDao.PrintAll();
            FindAllTest();
            FindByNameTest();
            FindByIdTest();
        }
        public void InsertTest()
        {
            accessoryDao.Insert(new Accessory(1, "Ban co"));
            accessoryDao.Insert(new Accessory(2, "Quan Co"));
            accessoryDao.Insert(new Accessory(3, "Ban Bi-a"));
            accessoryDao.Insert(new Accessory(4, "Hop Co"));
            accessoryDao.Insert(new Accessory(5, "La bai"));
            accessoryDao.Insert(new Accessory(6, "La bai"));
            accessoryDao.Insert(new Accessory(7, "La bai"));
            accessoryDao.Insert(new Accessory(8, "La bai"));
        }

        public void UpdateTest()
        {
            accessoryDao.Update(new Accessory(1, "Updated - BanCo"));
            accessoryDao.Update(new Accessory(2, "Updated - QuanCo"));
            accessoryDao.Update(new Accessory(3, "Updated - BanBia"));
            accessoryDao.Update(new Accessory(4, "Updated - HopCo"));
            accessoryDao.Update(new Accessory(5, "Updated - LaBai"));
            accessoryDao.SaveChange();
            accessoryDao.Load();
        }
        public void DeleteTest()
        {
            accessoryDao.Delete(new Accessory(6, "La bai"));
            accessoryDao.SaveChange();
            accessoryDao.Load();
        }
        public void FindAllTest()
        {
            Console.WriteLine("FindAll Test");
            List<Accessory> accessories = accessoryDao.FindAll(new Accessory(6, "La bai"));
            foreach (Accessory accessory in accessories)
            {
                Console.WriteLine(accessory);
            }
        }

        public void FindByNameTest()
        {
            Console.WriteLine("FindByName Test");
            Accessory accessory = accessoryDao.FindByName("Updated - BanBia");
            Accessory accessory1 = accessoryDao.FindByName("Updated - BanCo");
            Accessory accessory2 = accessoryDao.FindByName("Ban co");
            Accessory accessory3 = accessoryDao.FindByName("Quan co");
            Console.WriteLine("{0}, {1}, {2}, {3}", accessory, accessory1, accessory2, accessory3);
        }

        public void FindByIdTest()
        {
            Console.WriteLine("FindById Test");
            Accessory accessory = accessoryDao.FindById(1);
            Console.WriteLine(accessory);
        }
    }
}
