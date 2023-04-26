namespace OOP_Cong.Abtracts
{
    public abstract class BaseDAO<T> where T : BaseRow
    {
        protected List<BaseRow> data;

        public List<T> FindAll(T row)
        {
            return data.FindAll(p => p.Name == row.Name).Cast<T>().ToList();
        }

        public T FindById(int id)
        {
            return (T)data.Find(p => p.Id == id);
        }

        public T FindByName(string name)
        {
            return (T)data.Find(p => p.Name.Equals( name));
        }

        public int Insert(T row)
        {
            data.Add(row);
            return 0;
        }
        public bool Delete(T row)
        {
            return data.Remove(row);
        }


        public int Update(T row)
        {
            int index = data.FindIndex(p => p.Id == row.Id);
            if (index >= 0)
            {
                data[index] = row;
            }
            return index;
        }
        public void Load()
        {
            throw new NotImplementedException();
        }
        public bool SaveChange()
        {
            throw new NotImplementedException();
        }

        public void PrintAll()
        {
            foreach(T obj in data)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}