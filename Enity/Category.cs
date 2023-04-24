using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cong.Enity
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }

        public Category() {
            id = -1;
            name = "Category Name";
        }
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return string.Format("[id: {0}, name: {1}]", id, name);
        }

        public override bool Equals(object? obj)
        {
            return obj is Category category &&
                   id == category.id &&
                   name == category.name;
        }
    }
}
