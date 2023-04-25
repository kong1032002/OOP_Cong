namespace OOP_Cong.Abtracts
{
    public abstract class BaseDAO<T>
    {
        protected List<T> data;
        public abstract int Insert(T row);
        public abstract int Update(T row);
        public abstract bool Delete(T row);
        public abstract List<T> FindAll(T row);
        public abstract T FindById(int id);
        public abstract T FindByName(string name);
        public abstract void Load();
    }
}