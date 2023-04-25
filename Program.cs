// See https://aka.ms/new-console-template for more information
using OOP_Cong.Demo;

DatabaseDemo database = new DatabaseDemo();
database.initDatabase();
database.insertTableTest();
database.updateTableTest();
database.deleteTableTest();
database.printTableTest();
database.truncateTableTest();
ProductDaoDemo productDaoDemo = new ProductDaoDemo();
productDaoDemo.insertTest();
productDaoDemo.updateTest();
productDaoDemo.deleteTest();
productDaoDemo.findAllTest();
productDaoDemo.findByIdTest();
productDaoDemo.findByNameTest();