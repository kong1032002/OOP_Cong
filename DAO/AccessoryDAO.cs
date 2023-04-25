﻿using OOP_Cong.Abtracts;
using OOP_Cong.Enity;

namespace OOP_Cong.DAO
{
    public class AccessoryDAO : BaseDAO<Accessory>
    {
        private List<Accessory> accessories = Database.Instance.SelectTable(Database.AccessoryTableName).Cast<Accessory>().ToList();
        public AccessoryDAO() { }
        public override int Insert(Accessory row)
        {
            return Database.Instance.InsertTable(Database.AccessoryTableName, row);
        }
        public override int Update(Accessory row)
        {
            Database.Instance.UpdateTable(Database.AccessoryTableName, row);
            Load();
            return 0;
        }
        public override bool Delete(Accessory row)
        {
            bool isSuccess = Database.Instance.DeleteTable(Database.AccessoryTableName, row);
            if (isSuccess)
            {
                Load();
            }
            return isSuccess;
        }
        public override List<Accessory> FindAll(Accessory row)
        {
            return accessories.FindAll(p => p.Name == row.Name);
        }
        public override Accessory FindById(int id)
        {
            return accessories.Find(p => p.Id == id);
        }
        public override Accessory FindByName(string name)
        {
            return accessories.Find(p => p.Name == name);
        }
        public override void Load()
        {
            accessories = Database.Instance.SelectTable(Database.AccessoryTableName).Cast<Accessory>().ToList();
        }
    }
}
