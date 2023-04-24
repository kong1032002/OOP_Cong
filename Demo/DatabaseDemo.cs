using OOP_Cong.DAO;
using OOP_Cong.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cong.Demo
{
    public class DatabaseDemo
    {
        public void insertTableTest()
        {
            Database.instants.InsertTable("productTable", new Product());
            Database.instants.InsertTable("productTable", new Product(0, "Vua", 0));
            Database.instants.InsertTable("productTable", new Product(1, "Ma", 0));
            Database.instants.InsertTable("productTable", new Product(2, "Tinh", 0));
            Database.instants.InsertTable("productTable", new Product(3, "Hau", 0));
            Database.instants.InsertTable("productTable", new Product(4, "Xe", 0));
            Database.instants.InsertTable("productTable", new Product(5, "Tuong", 1));
            Database.instants.InsertTable("productTable", new Product(6, "Si", 1));
            Database.instants.InsertTable("productTable", new Product(7, "Ma", 1));
            Database.instants.InsertTable("productTable", new Product(8, "Tinh", 1));
            Database.instants.InsertTable("productTable", new Product(9, "Xe", 1));

            Database.instants.InsertTable("categoryTable", new Category(0, "Co vua"));
            Database.instants.InsertTable("categoryTable", new Category(1, "Co tuong"));
            Database.instants.InsertTable("categoryTable", new Category(2, "Co ty phu"));
            Database.instants.InsertTable("categoryTable", new Category(3, "Co vay"));
            Database.instants.InsertTable("categoryTable", new Category(4, "Co ca ngua"));
            Database.instants.InsertTable("categoryTable", new Category(5, "Mat chuoc"));
            Database.instants.InsertTable("categoryTable", new Category(6, "Phom"));
            Database.instants.InsertTable("categoryTable", new Category(7, "Bi a"));
            Database.instants.InsertTable("categoryTable", new Category(8, "Tien len"));
            Database.instants.InsertTable("categoryTable", new Category(9, "Kim cuong"));

            Database.instants.InsertTable("accessotionTable", new Accessotion(0, "Ban co"));
            Database.instants.InsertTable("accessotionTable", new Accessotion(1, "Hop co"));
            Database.instants.InsertTable("accessotionTable", new Accessotion(2, "Khung bai"));
            Database.instants.InsertTable("accessotionTable", new Accessotion(3, "Bi"));
            Database.instants.InsertTable("accessotionTable", new Accessotion(4, "Gay"));
            Database.instants.InsertTable("accessotionTable", new Accessotion(5, "Ban"));
            Database.instants.InsertTable("accessotionTable", new Accessotion(6, "Tay"));
            Database.instants.InsertTable("accessotionTable", new Accessotion(7, "Quan co"));
            Database.instants.InsertTable("accessotionTable", new Accessotion(8, "Tay phu"));
            Database.instants.InsertTable("accessotionTable", new Accessotion());
        }

        public void updateTableTest() {
            Database.instants.UpdateTable("categoryTable", new Category(6, "Poker"));
            Database.instants.UpdateTable("accessotionTable", new Accessotion(6, "Cuc tay"));
            Database.instants.UpdateTable("productTable", new Product(0, "Vuong", 0));
        }
        public void deleteTableTest() {
            Database.instants.DeleteTable("categoryTable", 9);
            Database.instants.DeleteTable("productTable", 9);
            Database.instants.DeleteTable("accessotionTable", 9);

        }
        public void truncateTableTest() { 
            Database.instants.TruncateTable("accessotionTable");
            Database.instants.TruncateTable("productTable");
            Database.instants.TruncateTable("categoryTable");
        }
        public void initDatabase() {
            Database.instants = new Database();

        }

        public void printTableTest() {
            Console.WriteLine("---------Category Table");
            foreach (Category category in Database.instants.SelectTable("categoryTable"))
            {
                Console.WriteLine(category);
            }
            Console.WriteLine("---------Product Table");
            foreach (Product product in Database.instants.SelectTable("productTable"))
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("---------Accessotion Table");
            foreach (Accessotion accessotion in Database.instants.SelectTable("accessotionTable"))
            {
                Console.WriteLine(accessotion);
            }
            Console.WriteLine("---------Select Where");
            //Func<Object, bool> productCondition = c => c == 1;
            //Database.instants.SelectTable("productTable", productCondition);
        }

    }
}
