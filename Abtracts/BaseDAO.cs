namespace OOP_Cong.Abtracts
{
    public abstract class BaseDAO<T> where T : BaseRow
    {
        protected List<BaseRow> data;
        /// <summary>
        /// Find all object has Name = row.Name
        /// </summary>
        /// <param name="row"></param>
        /// <returns>List result object</returns>
        public List<T> FindAll(T row)
        {
            return data.FindAll(p => p.Name == row.Name).Cast<T>().ToList();
        }
        /// <summary>
        /// Find first object has Id = id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Result object</returns>
        public T FindById(int id)
        {
            return (T)data.Find(p => p.Id == id);
        }
        /// <summary>
        /// Find first Object has Name == name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Result object</returns>
        public T FindByName(string name)
        {
            return (T)data.Find(p => p.Name.Equals( name));
        }
        /// <summary>
        /// Insert object to data
        /// </summary>
        /// <param name="row">Object you want to insert</param>
        /// <returns></returns>
        public int Insert(T row)
        {
            data.Add(row);
            return 0;
        }
        /// <summary>
        /// Delete object from data
        /// </summary>
        /// <param name="row">Object you want to Delete</param>
        /// <returns>True: Delete Success; Fasle: Fail</returns>
        public bool Delete(T row)
        {
            return data.Remove(row);
        }
        /// <summary>
        /// Update row from data
        /// </summary>
        /// <param name="row">New Object Information with row.Id == old.Id</param>
        /// <returns>Index of row</returns>
        public int Update(T row)
        {
            int index = data.FindIndex(p => p.Id == row.Id);
            if (index >= 0)
            {
                data[index] = row;
            }
            return index;
        }
        /// <summary>
        /// Load data from Database
        /// </summary>
        public void Load()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Save data to Database
        /// </summary>
        /// <returns></returns>
        public bool SaveChange()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Print all data
        /// </summary>
        public void PrintAll()
        {
            foreach(T obj in data)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}