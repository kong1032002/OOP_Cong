using OOP_Cong.Abtracts;

namespace OOP_Cong.Enity
{
    public class Accessory : BaseRow
    {
        public Accessory()
        {
            Id = 0;
            Name = "";
        }

        public Accessory(int id, string name)
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
            return obj is Accessory accessotion &&
                   Id == accessotion.Id &&
                   Name == accessotion.Name;
        }
    }
}
