using OOP_Cong.DAO;
using OOP_Cong.Enity;

namespace OOP_Cong.Demo
{
    public class DatabaseDemo
    {
        public void insertTableTest()
        {
            Database.Instants.insertTable("productTable", new Product());
            Database.Instants.insertTable("productTable", new Product(0, "Vua", 0));
            Database.Instants.insertTable("productTable", new Product(1, "Ma", 0));
            Database.Instants.insertTable("productTable", new Product(2, "Tinh", 0));
            Database.Instants.insertTable("productTable", new Product(3, "Hau", 0));
            Database.Instants.insertTable("productTable", new Product(4, "Xe", 0));
            Database.Instants.insertTable("productTable", new Product(5, "Tuong", 1));
            Database.Instants.insertTable("productTable", new Product(6, "Si", 1));
            Database.Instants.insertTable("productTable", new Product(7, "Ma", 1));
            Database.Instants.insertTable("productTable", new Product(8, "Tinh", 1));
            Database.Instants.insertTable("productTable", new Product(9, "Xe", 1));

            Database.Instants.insertTable("categoryTable", new Category(0, "Co vua"));
            Database.Instants.insertTable("categoryTable", new Category(1, "Co tuong"));
            Database.Instants.insertTable("categoryTable", new Category(2, "Co ty phu"));
            Database.Instants.insertTable("categoryTable", new Category(3, "Co vay"));
            Database.Instants.insertTable("categoryTable", new Category(4, "Co ca ngua"));
            Database.Instants.insertTable("categoryTable", new Category(5, "Mat chuoc"));
            Database.Instants.insertTable("categoryTable", new Category(6, "Phom"));
            Database.Instants.insertTable("categoryTable", new Category(7, "Bi a"));
            Database.Instants.insertTable("categoryTable", new Category(8, "Tien len"));
            Database.Instants.insertTable("categoryTable", new Category(9, "Kim cuong"));

            Database.Instants.insertTable("accessotionTable", new Accessory(0, "Ban co"));
            Database.Instants.insertTable("accessotionTable", new Accessory(1, "Hop co"));
            Database.Instants.insertTable("accessotionTable", new Accessory(2, "Khung bai"));
            Database.Instants.insertTable("accessotionTable", new Accessory(3, "Bi"));
            Database.Instants.insertTable("accessotionTable", new Accessory(4, "Gay"));
            Database.Instants.insertTable("accessotionTable", new Accessory(5, "Ban"));
            Database.Instants.insertTable("accessotionTable", new Accessory(6, "Tay"));
            Database.Instants.insertTable("accessotionTable", new Accessory(7, "Quan co"));
            Database.Instants.insertTable("accessotionTable", new Accessory(8, "Tay phu"));
            Database.Instants.insertTable("accessotionTable", new Accessory());
        }

        public void updateTableTest()
        {
            Database.Instants.updateTable("categoryTable", new Category(6, "Poker"));
            Database.Instants.updateTable("accessotionTable", new Accessory(6, "Cuc tay"));
            Database.Instants.updateTable("productTable", new Product(0, "Vuong", 0));
        }
        public void deleteTableTest()
        {
            Database.Instants.deleteTable("categoryTable", 9);
            Database.Instants.deleteTable("productTable", 9);
            Database.Instants.deleteTable("accessotionTable", 9);

        }
        public void truncateTableTest()
        {
            Database.Instants.truncateTable("accessotionTable");
            Database.Instants.truncateTable("productTable");
            Database.Instants.truncateTable("categoryTable");
        }
        public void initDatabase()
        {
            Database.Instants = new Database();

        }

        public void printTableTest()
        {
            Console.WriteLine("---------Category Table");
            foreach (Category category in Database.Instants.selectTable("categoryTable"))
            {
                Console.WriteLine(category);
            }
            Console.WriteLine("---------Product Table");
            foreach (Product product in Database.Instants.selectTable("productTable"))
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("---------Accessotion Table");
            foreach (Accessory accessotion in Database.Instants.selectTable("accessotionTable"))
            {
                Console.WriteLine(accessotion);
            }
            Console.WriteLine("---------Select Where");
            //Func<Object, bool> productCondition = c => c == 1;
            //Database.instants.SelectTable("productTable", productCondition);
        }

    }
}
