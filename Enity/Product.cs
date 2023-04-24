using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cong.Enity
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int categoryid { get; set; }

        public Product() {
            this.id = -1;
            this.name = "Product Name";
            this.categoryid = -1;
        }

        public Product(int id, string name, int categoryid)
        {
            this.id = id;
            this.name = name;
            this.categoryid = categoryid;
        }

        public override string? ToString()
        {
            return string.Format("[id: {0}, name: {1}, categoryId: {2}]", id, name, categoryid);
        }

        public override bool Equals(object? obj)
        {
            return obj is Product product &&
                   id == product.id &&
                   name == product.name &&
                   categoryid == product.categoryid;
        }
    }
}
