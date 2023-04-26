using OOP_Cong.Abtracts;

namespace OOP_Cong.Interface
{
    public interface IDao<T> where T : BaseRow
    {
        public List<T> FindAll(T row);
        public BaseRow FindById(int id);
        public BaseRow FindByName(string name);
        public int Insert(T row);
        public int Update(T row);
        public bool Delete(T row);
        public void Load();
        public bool SaveChange();

        public void PrintAll();
    }
}
