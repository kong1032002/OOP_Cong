using OOP_Cong.Abtracts;
using OOP_Cong.Enity;

namespace OOP_Cong.DAO
{
    public class Database
    {
        public const string ProductTableName = "producttable";
        public const string CategoryTableName = "categorytable";
        public const string AccessoryTableName = "accessotiontable";

        private List<Product> productTable = new();
        private List<Category> categoryTable = new();
        private List<Accessory> accessoryTable = new();

        private static Database instance;

        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }
        private Database() { }
        public int InsertTable(string name, BaseRow row)
        {
            switch (name.ToLower())
            {
                case ProductTableName:
                    {
                        productTable.Add((Product)row);
                        break;
                    }
                case CategoryTableName:
                    {
                        categoryTable.Add((Category)row);
                        break;
                    }
                case AccessoryTableName:
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

        public int UpdateTable(string name, BaseRow row)
        {
            switch (name.ToLower())
            {
                case ProductTableName:
                    {
                        int index = productTable.FindIndex(product => product.Id == row.Id);
                        if (index == -1)
                            throw new Exception(string.Format("Can't not find Product has id = {0}", row.Id));
                        productTable[index] = (Product)row;
                        break;
                    }
                case CategoryTableName:
                    {
                        int index = categoryTable.FindIndex(category => category.Id == row.Id);
                        if (index == -1)
                        {
                            throw new Exception(string.Format("Can't not find Category with id = {0}", row.Id));
                        }
                        categoryTable[index] = (Category)row;
                        break;
                    }
                case AccessoryTableName:
                    {
                        int index = accessoryTable.FindIndex(accessotion => accessotion.Id == row.Id);
                        if (index == -1)
                        {
                            throw new Exception(string.Format("Can't not find Accessotion with id = {0}", row.Id));
                        }
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
        public bool DeleteTable(string name, BaseRow row)
        {
            switch (name.ToLower())
            {
                case ProductTableName:
                    {
                        return productTable.RemoveAll(product => product.Id == row.Id) > 0 ? true : false;
                    }
                case CategoryTableName:
                    {
                        return categoryTable.RemoveAll(category => category.Id == row.Id) > 0 ? true : false;
                    }
                case AccessoryTableName:
                    {
                        return accessoryTable.RemoveAll(accessotion => accessotion.Id == row.Id) > 0 ? true : false;
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
                case ProductTableName:
                    {
                        productTable.Clear();
                        break;
                    }
                case CategoryTableName:
                    {
                        categoryTable.Clear();
                        break;
                    }
                case AccessoryTableName:
                    {
                        categoryTable.Clear();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        public List<BaseRow> SelectTable(string name)
        {
            switch (name.ToLower())
            {
                case ProductTableName:
                    {
                        return productTable.Cast<BaseRow>().ToList();
                    }
                case CategoryTableName:
                    {
                        return categoryTable.Cast<BaseRow>().ToList();
                    }
                case AccessoryTableName:
                    {
                        return accessoryTable.Cast<BaseRow>().ToList();
                    }
                default:
                    {
                        return null;
                    }
            }
        }

        public List<BaseRow> SelectTable(string name, Func<BaseRow, bool> where)
        {
            switch (name.ToLower())
            {
                case ProductTableName:
                    {
                        return productTable.FindAll(p => where(p)).Cast<BaseRow>().ToList();
                    }
                case CategoryTableName:
                    {
                        return categoryTable.FindAll(p => where(p)).Cast<BaseRow>().ToList();
                    }
                case AccessoryTableName:
                    {
                        return accessoryTable.FindAll(p => where(p)).Cast<BaseRow>().ToList();
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
