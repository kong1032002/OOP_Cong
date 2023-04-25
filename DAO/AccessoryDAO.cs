using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Cong.Enity;

namespace OOP_Cong.DAO
{
    internal class AccessoryDAO
    {
        List<Accessory> accessotions = Database.Instants.selectTable(Database.accessoryTableName).Cast<Accessory>().ToList();
        public AccessoryDAO() { }

        public int insert()
        {
            return 0;
        }

        public int update() { return 0; }
        public bool delete() { return false; }
        public List<Accessory> findAll(string name)
        {
            return new List<Accessory>();
        }
        public Accessory findById(int id)
        {
            return new Accessory();
        }
        public Accessory findByName(string name) {
            return new Accessory();
        }
    }
}
