using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cong.Enity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }



        public Product() {
            this.Id = 0;
            this.Name = "";
            this.CategoryId = 0;
        }

        public Product(int id, string name, int categoryid)
        {
            this.Id = id;
            this.Name = name;
            this.CategoryId = categoryid;
        }

        public override string? ToString()
        {
            return string.Format("[id: {0}, name: {1}, categoryId: {2}]", Id, Name, CategoryId);
        }

        public override bool Equals(object? obj)
        {
            return obj is Product product &&
                   Id == product.Id &&
                   Name == product.Name &&
                   CategoryId == product.CategoryId;
        }
    }
}
