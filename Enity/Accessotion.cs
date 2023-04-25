using OOP_Cong.Abtracts;
using OOP_Cong.Interface;

namespace OOP_Cong.Enity
{
    public class Accessory : BaseRow, IEntity
    {
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
