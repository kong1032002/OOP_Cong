using OOP_Cong.DAO;
using OOP_Cong.Enity;

namespace OOP_Cong.Abtracts
{
    public abstract class BaseDAO<T> where T : BaseRow
    {
        /// <summary>
        /// Find all object has Name = row.Name
        /// </summary>
        /// <param name="row">Data row</param>
        /// <returns>List result object</returns>
        public List<T> FindAll(T row)
        {
            string tableName = "";
            if (row is Accessory)
            {
                tableName = Database.ACCESSORY_TABLE_NAME;
            }
            else if (row is Category)
            {
                tableName = Database.CATEGORY_TABLE_NAME;
            }
            else if (row is Product)
            {
                tableName = Database.PRODUCT_TABLE_NAME;
            }
            return Database.Instance.SelectTable(tableName).FindAll(p => p.Name == row.Name)
                .Cast<T>().ToList();
        }
        /// <summary>
        /// Find first object has Id = id
        /// </summary>
        /// <param name="id">id row</param>
        /// <returns>Result object</returns>
        public T FindById(int id)
        {
            string tableName = "";
            if (typeof(T) == typeof(Accessory))
            {
                tableName = Database.ACCESSORY_TABLE_NAME;
            }
            else if (typeof(T) == typeof(Category))
            {
                tableName = Database.CATEGORY_TABLE_NAME;
            }
            else if (typeof(T) == typeof(Product))
            {
                tableName = Database.PRODUCT_TABLE_NAME;
            }
            return Database.Instance.SelectTable(tableName)
                .Cast<T>().ToList().Find(p => p.Id == id);
        }
        /// <summary>
        /// Find first Object has Name == name
        /// </summary>
        /// <param name="name">row name</param>
        /// <returns>Result object</returns>
        public T FindByName(string name)
        {
            string tableName = "";
            if (typeof(T).Equals(typeof(Accessory)))
            {
                tableName = Database.ACCESSORY_TABLE_NAME;
            }
            else if (typeof(T).Equals(typeof(Category)))
            {
                tableName = Database.CATEGORY_TABLE_NAME;
            }
            else if (typeof(T).Equals(typeof(Product)))
            {
                tableName = Database.PRODUCT_TABLE_NAME;
            }
            return Database.Instance.SelectTable(tableName)
                .Cast<T>().ToList().Find(p => p.Name.Equals(name));
        }
        /// <summary>
        /// Insert object to data
        /// </summary>
        /// <param name="row">Object you want to insert</param>
        /// <returns></returns>
        public int Insert(T row)
        {
            string tableName = "";
            if (typeof(T) == typeof(Accessory))
            {
                tableName = Database.ACCESSORY_TABLE_NAME;
            }
            else if (typeof(T) == typeof(Category))
            {
                tableName = Database.CATEGORY_TABLE_NAME;
            }
            else if (typeof(T) == typeof(Product))
            {
                tableName = Database.PRODUCT_TABLE_NAME;
            }
            return Database.Instance.InsertTable(tableName, row);
        }
        /// <summary>
        /// Delete object from data
        /// </summary>
        /// <param name="row">Object you want to Delete</param>
        /// <returns>True: Delete Success; Fasle: Fail</returns>
        public bool Delete(T row)
        {
            if (typeof(T).Equals(typeof(Accessory)))
            {
                return Database.Instance.DeleteTable(Database.ACCESSORY_TABLE_NAME, row);
            }
            else if (typeof(T).Equals(typeof(Category)))
            {
                return Database.Instance.DeleteTable(Database.CATEGORY_TABLE_NAME, row);
            }
            else if (typeof(T).Equals(typeof(Product)))
            {
                return Database.Instance.DeleteTable(Database.PRODUCT_TABLE_NAME, row);
            }
            return false;
        }
        /// <summary>
        /// Update row from data
        /// </summary>
        /// <param name="row">New Object Information with row.Id == old.Id</param>
        /// <returns>Index of row</returns>
        public int Update(T row)
        {
            string tableName = "";
            if (typeof(T) == typeof(Accessory))
            {
                tableName = Database.ACCESSORY_TABLE_NAME;
            }
            else if (typeof(T) == typeof(Category))
            {
                tableName = Database.CATEGORY_TABLE_NAME;
            }
            else if (typeof(T) == typeof(Product))
            {
                tableName = Database.PRODUCT_TABLE_NAME;
            }
            return Database.Instance.UpdateTable(tableName, row);
        }
        /// <summary>
        /// Print all data
        /// </summary>
        public void PrintAll()
        {
            string tableName = "";
            if (typeof(T) == typeof(Accessory))
            {
                tableName = Database.ACCESSORY_TABLE_NAME;
            }
            else if (typeof(T) == typeof(Category))
            {
                tableName = Database.CATEGORY_TABLE_NAME;
            }
            else if (typeof(T) == typeof(Product))
            {
                tableName = Database.PRODUCT_TABLE_NAME;
            }
            foreach (T obj in Database.Instance.SelectTable(tableName).Cast<T>().ToList())
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}