﻿namespace OOP_Cong.Enity
{
    public class Accessotion
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Accessotion()
        {
            Id = 0;
            Name = "";
        }

        public Accessotion(int id, string name)
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
            return obj is Accessotion accessotion &&
                   Id == accessotion.Id &&
                   Name == accessotion.Name;
        }
    }
}
