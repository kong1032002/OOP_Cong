using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Cong.Enity
{
    public class Accessotion
    {
        public int id { get; set; }
        public string name { get; set; }

        public Accessotion() {
            id = -1;
            name = "Accessotion Name";
        }

        public Accessotion(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public override string ToString()
        {
            return string.Format("[id: {0}, name: {1}]", id, name);
        }

        public override bool Equals(object? obj)
        {
            return obj is Accessotion accessotion &&
                   id == accessotion.id &&
                   name == accessotion.name;
        }
    }
}
