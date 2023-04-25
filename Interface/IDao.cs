using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cong.Interface
{
    public interface IDao<T>
    {
        public int Insert(T row);
        public int Update(T row);
        public bool Delete(T row);
        public List<T> FindAll(T row);
        public T FindById(int id);
        public T FindByName(string name);
        public void Load();
    }
}
