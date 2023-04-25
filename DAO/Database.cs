using OOP_Cong.Enity;

namespace OOP_Cong.DAO
{
    public class Database
    {

        private List<Product> productTable = new List<Product>();
        private List<Category> categoryTable = new List<Category>();
        private List<Accessory> accessoryTable = new List<Accessory>();

        public static Database Instants = new Database();

        public const string productTableName = "producttable";
        public const string categoryTableName = "categorytable";
        public const string accessoryTableName = "accessotiontable";


        public Database() { }

        public int insertTable(string name, Object row)
        {
            switch (name.ToLower())
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
                case accessoryTableName:
                    {
                        accessoryTable.Add((Accessory)row);
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
                case productTableName:
                    {
                        Product newProduct = (Product)row;
                        int index = productTable.FindIndex(product => product.Id == newProduct.Id);
                        if (index == -1)
                            throw new Exception(string.Format("Can't not find Product has id = {0}", newProduct.Id));
                        productTable[index] = newProduct;
                        break;
                    }
                case categoryTableName:
                    {
                        Category newCategory = (Category)row;
                        int index = categoryTable.FindIndex(category => category.Id == newCategory.Id);
                        if (index == -1)
                        {
                            throw new Exception(string.Format("Can't not find Category with id = {0}", newCategory.Id));
                        }
                        categoryTable[index] = newCategory;
                        break;
                    }
                case accessoryTableName:
                    {
                        Accessory newAccessory = (Accessory)row;
                        int index = accessoryTable.FindIndex(accessotion => accessotion.Id == newAccessory.Id);
                        if (index == -1)
                        {
                            throw new Exception(string.Format("Can't not find Accessotion with id = {0}", newAccessory.Id));
                        }
                        accessoryTable[index] = newAccessory;
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
                case productTableName:
                    {
                        int index = productTable.FindIndex(product => product.Id == id);
                        if (index == -1)
                            throw new Exception(string.Format("Can't not find Product has id = {0}", id));
                        productTable[index] = (Product)row;
                        break;
                    }
                case categoryTableName:
                    {
                        int index = categoryTable.FindIndex(category => category.Id == id);
                        if (index == -1)
                            throw new Exception(string.Format("Can't not find Category has id = {0}", id));
                        categoryTable[index] = (Category)row;
                        break;
                    }
                case accessoryTableName:
                    {
                        int index = accessoryTable.FindIndex(accessotion => accessotion.Id == id);
                        if (index == -1)
                            throw new Exception(string.Format("Can't not find Accessotion has id = {0}", id));
                        accessoryTable[index] = (Accessory)row;
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
                case productTableName:
                    {
                        return productTable.RemoveAll(product => product.Id == row) > 0 ? true : false;
                    }
                case categoryTableName:
                    {
                        return categoryTable.RemoveAll(category => category.Id == row) > 0 ? true : false;
                    }
                case accessoryTableName:
                    {
                        return accessoryTable.RemoveAll(accessotion => accessotion.Id == row) > 0 ? true : false;
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
                case productTableName:
                    {
                        productTable.Clear();
                        //productTable = new List<Product>();
                        break;
                    }
                case categoryTableName:
                    {
                        categoryTable.Clear();
                        //categoryTable = new List<Category>();
                        break;
                    }
                case accessoryTableName:
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
                case productTableName:
                    {
                        return productTable.Cast<object>().ToList();
                    }
                case categoryTableName:
                    {
                        return categoryTable.Cast<object>().ToList();
                    }
                case accessoryTableName:
                    {
                        return accessoryTable.Cast<object>().ToList();
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
                case productTableName:
                    {
                        List<Object> products = productTable.FindAll(p => where(p)).Cast<object>().ToList();
                        return products;
                    }
                case categoryTableName:
                    {
                        return categoryTable.FindAll(p => where(p)).Cast<object>().ToList();
                    }
                case accessoryTableName:
                    {
                        return accessoryTable.FindAll(p => where(p)).Cast<object>().ToList();
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
