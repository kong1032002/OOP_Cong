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

        public List<Product> productTable;
        private List<Category> categoryTable;
        private List<Accessotion> accessotionTable;
        public static Database instants = new Database();
        public Database()
        {
            productTable = new List<Product>();
            categoryTable = new List<Category>();
            accessotionTable = new List<Accessotion>();
        }

        public int InsertTable(string name, Object row)
        {
            switch(name.ToLower())
            {
                case "producttable":
                    {
                        productTable.Add((Product)row);
                        break;
                    }
                case "categorytable":
                    {
                        categoryTable.Add((Category)row);
                        break;
                    }
                case "accessotiontable":
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

        public List<Category> GetCategoryTable()
        {
            return categoryTable;
        }

        public int UpdateTable(string name, Object row)
        {
            switch (name.ToLower())
            {
                //Product newPro
                case "producttable":
                    {
                        Product newP = (Product)row;
                        int index = productTable.FindIndex(product => product.id == newP.id);
                        productTable[index] = newP;
                        break;
                    }
                case "categorytable":
                    {
                        Category newC = (Category)row;
                        int index = categoryTable.FindIndex(category => category.id == newC.id);
                        categoryTable[index] = newC;
                        break;
                    }
                case "accessotiontable":
                    {
                        Accessotion newA = (Accessotion)row;
                        int index = accessotionTable.FindIndex(accessotion => accessotion.id == newA.id);
                        accessotionTable[index] = newA;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return 0;
        }

        public int UpdateTableById(string name, int id, Object row)
        {
            switch (name.ToLower())
            {
                //Product newPro
                case "producttable":
                    {
                        Product newP = (Product)row;
                        int index = productTable.FindIndex(product => product.id == id);
                        productTable[index] = newP;
                        break;
                    }
                case "categorytable":
                    {
                        Category newC = (Category)row;
                        int index = categoryTable.FindIndex(category => category.id == id);
                        categoryTable[index] = newC;
                        break;
                    }
                case "accessotiontable":
                    {
                        Accessotion newA = (Accessotion)row;
                        int index = accessotionTable.FindIndex(accessotion => accessotion.id == id);
                        accessotionTable[index] = newA;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return 0;
        }

        public bool DeleteTable(string name, int row)
        {
            switch (name.ToLower())
            {
                case "producttable":
                    {
                        return productTable.RemoveAll(product   => product.id == row) > 0 ? true : false;
                    }
                case "categorytable":
                    {
                        return categoryTable.RemoveAll(category => category.id == row) > 0 ? true : false;
                    }
                case "accessotiontable":
                    {
                        return accessotionTable.RemoveAll(accessotion => accessotion.id == row) > 0 ? true : false ;
                    }
                default:
                    {
                        break;
                    }
            }
            return false;
        }

        public void TruncateTable(string name)
        {
            switch (name.ToLower())
            {
                case "producttable":
                    {
                        productTable = new List<Product>();
                        break;
                    }
                case "categorytable":
                    {
                        categoryTable = new List<Category>();
                        break;
                    }
                case "accessotiontable":
                    {
                        accessotionTable = new List<Accessotion>();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        public List<object> SelectTable(string name)
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

        public List<object> SelectTable(string name, Func<object, bool> where)
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
