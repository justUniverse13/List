using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public override string ToString()
        {
            return "ID: " + Id + "   Name: " + Name;
        }
        public void RemovePeople()
        {

        }
    }
}
