using OOP_Cong.DAO;
using OOP_Cong.Enity;

namespace OOP_Cong.Demo
{
    public class DatabaseDemo
    {
        public void insertTableTest()
        {
            Database.Instance.InsertTable("productTable", new Product());
            Database.Instance.InsertTable("productTable", new Product(0, "Vua", 0));
            Database.Instance.InsertTable("productTable", new Product(1, "Ma", 0));
            Database.Instance.InsertTable("productTable", new Product(2, "Tinh", 0));
            Database.Instance.InsertTable("productTable", new Product(3, "Hau", 0));
            Database.Instance.InsertTable("productTable", new Product(4, "Xe", 0));
            Database.Instance.InsertTable("productTable", new Product(5, "Tuong", 1));
            Database.Instance.InsertTable("productTable", new Product(6, "Si", 1));
            Database.Instance.InsertTable("productTable", new Product(7, "Ma", 1));
            Database.Instance.InsertTable("productTable", new Product(8, "Tinh", 1));
            Database.Instance.InsertTable("productTable", new Product(9, "Xe", 1));

            Database.Instance.InsertTable("categoryTable", new Category(0, "Co vua"));
            Database.Instance.InsertTable("categoryTable", new Category(1, "Co tuong"));
            Database.Instance.InsertTable("categoryTable", new Category(2, "Co ty phu"));
            Database.Instance.InsertTable("categoryTable", new Category(3, "Co vay"));
            Database.Instance.InsertTable("categoryTable", new Category(4, "Co ca ngua"));
            Database.Instance.InsertTable("categoryTable", new Category(5, "Mat chuoc"));
            Database.Instance.InsertTable("categoryTable", new Category(6, "Phom"));
            Database.Instance.InsertTable("categoryTable", new Category(7, "Bi a"));
            Database.Instance.InsertTable("categoryTable", new Category(8, "Tien len"));
            Database.Instance.InsertTable("categoryTable", new Category(9, "Kim cuong"));

            Database.Instance.InsertTable("accessotionTable", new Accessory(0, "Ban co"));
            Database.Instance.InsertTable("accessotionTable", new Accessory(1, "Hop co"));
            Database.Instance.InsertTable("accessotionTable", new Accessory(2, "Khung bai"));
            Database.Instance.InsertTable("accessotionTable", new Accessory(3, "Bi"));
            Database.Instance.InsertTable("accessotionTable", new Accessory(4, "Gay"));
            Database.Instance.InsertTable("accessotionTable", new Accessory(5, "Ban"));
            Database.Instance.InsertTable("accessotionTable", new Accessory(6, "Tay"));
            Database.Instance.InsertTable("accessotionTable", new Accessory(7, "Quan co"));
            Database.Instance.InsertTable("accessotionTable", new Accessory(8, "Tay phu"));
            Database.Instance.InsertTable("accessotionTable", new Accessory());
        }

        public void updateTableTest()
        {
            Database.Instance.UpdateTable("categoryTable", new Category(6, "Poker"));
            Database.Instance.UpdateTable("accessotionTable", new Accessory(6, "Cuc tay"));
            Database.Instance.UpdateTable("productTable", new Product(0, "Vuong", 0));
        }
        public void deleteTableTest()
        {
            Database.Instance.DeleteTable("categoryTable", new Category());
            Database.Instance.DeleteTable("productTable", new Category());
            Database.Instance.DeleteTable("accessotionTable", new Category());

        }
        public void truncateTableTest()
        {
            Database.Instance.TruncateTable("accessotionTable");
            Database.Instance.TruncateTable("productTable");
            Database.Instance.TruncateTable("categoryTable");
        }
        public void initDatabase()
        {

        }

        public void printTableTest()
        {
            Console.WriteLine("---------Category Table");
            foreach (Category category in Database.Instance.SelectTable("categoryTable").Cast<Category>().ToList())
            {
                Console.WriteLine(category);
            }
            Console.WriteLine("---------Product Table");
            foreach (Product product in Database.Instance.SelectTable("productTable").Cast<Product>().ToList())
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("---------Accessotion Table");
            foreach (Accessory accessotion in Database.Instance.SelectTable("accessotionTable").Cast<Accessory>().ToList())
            {
                Console.WriteLine(accessotion);
            }
            Console.WriteLine("---------Select Where");
        }

    }
}
