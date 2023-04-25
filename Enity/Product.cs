using OOP_Cong.Abtracts;
using OOP_Cong.Interface;

namespace OOP_Cong.Enity
{
    public class Product : BaseRow, IEntity
    {
        private int categoryId;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }
        public Product()
        {
            Id = 0;
            Name = "";
            CategoryId = 0;
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
