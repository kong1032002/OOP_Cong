using OOP_Cong.Abtracts;

namespace OOP_Cong.Enity
{
    public class Product : BaseRow
    {
        private int categoryId;
        public int CategoryId {
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
