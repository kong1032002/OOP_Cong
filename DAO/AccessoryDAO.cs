using OOP_Cong.Abtracts;
using OOP_Cong.Enity;
using OOP_Cong.Interface;

namespace OOP_Cong.DAO
{
    public class AccessoryDAO : BaseDAO<Accessory>, IDao<Accessory>
    {
        public AccessoryDAO()
        {
            data = Database.Instance.SelectTable(Database.AccessoryTableName).Cast<Accessory>().ToList();
        }
        public int Insert(Accessory row)
        {
            return Database.Instance.InsertTable(Database.AccessoryTableName, row);
        }
        public int Update(Accessory row)
        {
            Database.Instance.UpdateTable(Database.AccessoryTableName, row);
            Load();
            return 0;
        }
        public bool Delete(Accessory row)
        {
            bool isSuccess = Database.Instance.DeleteTable(Database.AccessoryTableName, row);
            if (isSuccess)
            {
                Load();
            }
            return isSuccess;
        }
        public List<Accessory> FindAll(Accessory row)
        {
            return data.FindAll(p => p.Name == row.Name);
        }
        public Accessory FindById(int id)
        {
            return data.Find(p => p.Id == id);
        }
        public Accessory FindByName(string name)
        {
            return data.Find(p => p.Name == name);
        }
        public void Load()
        {
            data = Database.Instance.SelectTable(Database.AccessoryTableName).Cast<Accessory>().ToList();
        }
    }
}
