using OOP_Cong.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cong.DAO
{
    public class Database
    {

        private List<Product> productTable;
        private List<Category> categoryTable;
        private List<Accessotion> accessotionTable;
        public static Database Instants = new Database();
        private const string productTableName = "producttable";
        private const string categoryTableName = "categorytable";
        private const string accessotionTableName = "accessotiontable";


        public Database()
        {
            productTable = new List<Product>();
            categoryTable = new List<Category>();
            accessotionTable = new List<Accessotion>();
        }

        public int insertTable(string name, Object row)
        {
            switch(name.ToLower())
            {
                case productTableName:
                    {
                        productTable.Add((Product)row);
                        break;
                    }
                case categoryTableName:
                    {
                        categoryTable.Add((Category)row);
                        break;
                    }
                case accessotionTableName:
                    {
                        accessotionTable.Add((Accessotion)row);
                        break;
                    }
                default: 
                    {
                        break;
                    }
            }
            return 0;
        }

        public List<Category> getCategoryTable()
        {
            return categoryTable;
        }

        public int updateTable(string name, Object row)
        {
            switch (name.ToLower())
            {
                //Product newPro
                case "producttable":
                    {
                        Product newProduct = (Product)row;
                        int index = productTable.FindIndex(product => product.Id == newProduct.Id);
                        if (index == -1)
                            throw new Exception(string.Format("Can't not find Product has id = {0}", newProduct.Id));
                        productTable[index] = newProduct;
                        break;
                    }
                case "categorytable":
                    {
                        Category newCategory = (Category)row;
                        int index = categoryTable.FindIndex(category => category.Id == newCategory.Id);
                        if(index == - 1)
                        {
                            throw new Exception(string.Format("Can't not find Category with id = {0}", newCategory.Id));
                        }
                        categoryTable[index] = newCategory;
                        break;
                    }
                case "accessotiontable":
                    {
                        Accessotion newAccessotion = (Accessotion)row;
                        int index = accessotionTable.FindIndex(accessotion => accessotion.Id == newAccessotion.Id);
                        if (index == -1)
                        {
                            throw new Exception(string.Format("Can't not find Accessotion with id = {0}", newAccessotion.Id));
                        }
                        accessotionTable[index] = newAccessotion;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return 0;
        }

        public int updateTableById(string name, int id, Object row)
        {
            switch (name.ToLower())
            {
                //Product newPro
                case "producttable":
                    {
                        int index = productTable.FindIndex(product => product.Id == id);
                        if (index == -1)
                            throw new Exception(string.Format("Can't not find Product has id = {0}", id));
                        productTable[index] = (Product)row;
                        break;
                    }
                case "categorytable":
                    {
                        int index = categoryTable.FindIndex(category => category.Id == id);
                        if (index == -1)
                            throw new Exception(string.Format("Can't not find Category has id = {0}", id));
                        categoryTable[index] = (Category)row;
                        break;
                    }
                case "accessotiontable":
                    {
                        int index = accessotionTable.FindIndex(accessotion => accessotion.Id == id);
                        if (index == -1)
                            throw new Exception(string.Format("Can't not find Accessotion has id = {0}", id));
                        accessotionTable[index] = (Accessotion)row;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return 0;
        }

        public bool deleteTable(string name, int row)
        {
            switch (name.ToLower())
            {
                case "producttable":
                    {
                        return productTable.RemoveAll(product   => product.Id == row) > 0 ? true : false;
                    }
                case "categorytable":
                    {
                        return categoryTable.RemoveAll(category => category.Id == row) > 0 ? true : false;
                    }
                case "accessotiontable":
                    {
                        return accessotionTable.RemoveAll(accessotion => accessotion.Id == row) > 0 ? true : false ;
                    }
                default:
                    {
                        break;
                    }
            }
            return false;
        }

        public void truncateTable(string name)
        {
            switch (name.ToLower())
            {
                case "producttable":
                    {
                        productTable.Clear();
                        //productTable = new List<Product>();
                        break;
                    }
                case "categorytable":
                    {
                        categoryTable.Clear();
                        //categoryTable = new List<Category>();
                        break;
                    }
                case "accessotiontable":
                    {
                        categoryTable.Clear();
                        //accessotionTable = new List<Accessotion>();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        public List<object> selectTable(string name)
        {
            switch (name.ToLower())
            {
                case "producttable":
                    {
                        return productTable.Cast<object>().ToList();
                    }
                case "categorytable":
                    {
                        return categoryTable.Cast<object>().ToList();
                    }
                case "accessotiontable":
                    {
                        return accessotionTable.Cast<object>().ToList();
                    }
                default:
                    {
                        return null;
                    }
            }
        }

        public List<object> selectTable(string name, Func<object, bool> where)
        {
            switch (name.ToLower())
            {
                case "producttable":
                    {
                        List<Object> products = productTable.FindAll(p => where(p)).Cast<object>().ToList();
                        return products;
                    }
                case "categorytable":
                    {
                        return categoryTable.FindAll(p => where(p)).Cast<object>().ToList();
                    }
                case "accessotiontable":
                    {
                        return accessotionTable.FindAll(p => where(p)).Cast<object>().ToList();
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
