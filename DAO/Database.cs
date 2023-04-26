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
        /// <summary>
        /// Singleton Pattern
        /// </summary>
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
        /// <summary>
        /// Insert data to table
        /// </summary>
        /// <param name="name">Table name</param>
        /// <param name="row">Data row</param>
        /// <returns></returns>
        public int InsertTable(string name, BaseRow row)
        {
            name = name.ToLower();
            if (dictionary.ContainsKey(name.ToLower()))
            {
                dictionary[name].Add(row);
            }
            return 0;
        }
        /// <summary>
        /// Update data from table
        /// </summary>
        /// <param name="name">Table name</param>
        /// <param name="row">New data row</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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
        /// <summary>
        /// Delete data from table
        /// </summary>
        /// <param name="name">Table name</param>
        /// <param name="row">Delete row</param>
        /// <returns></returns>
        public bool DeleteTable(string name, IEntity row)
        {
            name = name.ToLower();

            if (dictionary.ContainsKey(name.ToLower()))
            {
                return dictionary[name].RemoveAll(p => p.Id == row.Id) > 0 ? true : false;
            }
            return false;
        }
        /// <summary>
        /// Clear table
        /// </summary>
        /// <param name="name">Table name</param>
        public void TruncateTable(string name)
        {
            name = name.ToLower();

            if (dictionary.ContainsKey(name.ToLower()))
            {
                dictionary[name].Clear();
            }
            return;
        }
        /// <summary>
        /// Get all data from table
        /// </summary>
        /// <param name="name">Table name</param>
        /// <returns>List of data</returns>
        public List<BaseRow> SelectTable(string name)
        {
            name = name.ToLower();

            if (dictionary.ContainsKey(name.ToLower()))
            {
                return dictionary[name].ToList();
            }
            return null;
        }
        /// <summary>
        /// Get all data from table with condition
        /// </summary>
        /// <param name="name">Table name</param>
        /// <param name="where">Condition</param>
        /// <returns></returns>
        public List<BaseRow> SelectTable(string name, Func<BaseRow, bool> where)
        {
            name = name.ToLower();

            if (dictionary.ContainsKey(name.ToLower()))
            {
                return dictionary[name].ToList();
            }
            return null;
        }
        /// <summary>
        /// Save data to table
        /// </summary>
        /// <param name="name">Table name</param>
        /// <param name="data">Data</param>
        /// <returns>True: Success; False: Fail</returns>
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
