namespace OOP_Cong.Enity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Category()
        {
            Id = 0;
            Name = "";
        }
        public Category(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return string.Format("[id: {0}, name: {1}]", Id, Name);
        }

        public override bool Equals(object? obj)
        {
            return obj is Category category &&
                   Id == category.Id &&
                   Name == category.Name;
        }
    }
}
