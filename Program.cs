// See https://aka.ms/new-console-template for more information
using OOP_Cong.DAO;
using OOP_Cong.Demo;
using OOP_Cong.Enity;

DatabaseDemo database = new DatabaseDemo();
database.initDatabase();
database.insertTableTest();
database.updateTableTest();
database.deleteTableTest();
database.printTableTest();
database.truncateTableTest();