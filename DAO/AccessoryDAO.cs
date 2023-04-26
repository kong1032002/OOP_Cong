using OOP_Cong.Abtracts;
using OOP_Cong.Enity;

namespace OOP_Cong.DAO
{
    public class AccessoryDAO : BaseDAO<Accessory>
    {
        public AccessoryDAO()
        {
            Load();
        }
        public void Load()
        {
            data = Database.Instance.SelectTable(Database.ACCESSORY_TABLE_NAME).ToList();
        }

        public bool SaveChange()
        {
            return Database.Instance.Save(Database.ACCESSORY_TABLE_NAME, data);
        }
    }
}
