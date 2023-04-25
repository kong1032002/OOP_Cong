using OOP_Cong.Abtracts;

namespace OOP_Cong.Enity
{
    public class Product : BaseRow
    {
        public int CategoryId { get; set; }
        public Product()
        {
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
