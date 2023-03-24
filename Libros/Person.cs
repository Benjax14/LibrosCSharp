using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros
{
    public class Person
    {
        public string Name { get; set; }
        public string Rut { get; set; }

        public Person(string name, string rut) {
        
            Name = name;
            Rut = rut;

        }
    }
}
