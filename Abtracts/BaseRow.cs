namespace OOP_Cong.Abtracts
{
    public abstract class BaseRow
    {
        private int id { get; set; }
        private string name { get; set; } = string.Empty;

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
