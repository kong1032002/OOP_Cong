using OOP_Cong.Abtracts;
using OOP_Cong.Interface;

namespace OOP_Cong.DAO
{
    public class Database
    {
        public const string PRODUCT_TABLE_NAME = "producttable";
        public const string CATEGORY_TABLE_NAME = "categorytable";
        public const string ACCESSORY_TABLE_NAME = "accessotiontable";

        private static List<BaseRow> productTable = new();
        private static List<BaseRow> categoryTable = new();
        private static List<BaseRow> accessoryTable = new();

        private static Dictionary<string, List<BaseRow>> dictionary = new() {
            {PRODUCT_TABLE_NAME,productTable},
            {CATEGORY_TABLE_NAME,categoryTable },
            {ACCESSORY_TABLE_NAME,accessoryTable}
        };

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
            name = name.ToLower();
            if (dictionary.ContainsKey(name.ToLower()))
            {
                dictionary[name].Add(row);
            }
            return 0;
        }
        public int UpdateTable(string name, IEntity row)
        {
            name = name.ToLower();

            if (dictionary.ContainsKey(name.ToLower()))
            {
                int index = dictionary[name].FindIndex(p => p.Id == row.Id);
                if (index == -1)
                    throw new Exception(string.Format("Can't find {0} has value = {1}", row.GetType(), row.ToString()));
            }
            return 0;
        }
        public bool DeleteTable(string name, IEntity row)
        {
            name = name.ToLower();

            if (dictionary.ContainsKey(name.ToLower()))
            {
                return dictionary[name].RemoveAll(p => p.Id == row.Id) > 0 ? true : false;
            }
            return false;
        }
        public void TruncateTable(string name)
        {
            name = name.ToLower();

            if (dictionary.ContainsKey(name.ToLower()))
            {
                dictionary[name].Clear();
            }
            return;
        }
        public List<BaseRow> SelectTable(string name)
        {
            name = name.ToLower();

            if (dictionary.ContainsKey(name.ToLower()))
            {
                return dictionary[name].ToList();
            }
            return null;
        }
        public List<BaseRow> SelectTable(string name, Func<BaseRow, bool> where)
        {
            name = name.ToLower();

            if (dictionary.ContainsKey(name.ToLower()))
            {
                return dictionary[name].ToList();
            }
            return null;
        }

        public bool Save(string name, List<BaseRow> data)
        {
            name = name.ToLower();

            if (dictionary.ContainsKey(name.ToLower()))
            {
                dictionary[name] = data;
                return dictionary[name] == data;
            }
            return false;
        }
    }
}
