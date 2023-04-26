using OOP_Cong.Interface;

namespace OOP_Cong.Abtracts
{
    public abstract class BaseRow : IEntity
    {
        protected int id;
        protected string name = string.Empty;
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
    }
}
