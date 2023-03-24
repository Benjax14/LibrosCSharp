using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros
{
    public class Data
    {
        public List<Book> Books { get; set; }
        public List<Person> Persons { get; set; }
        public List<Enterprise> Enterprises { get; set; }

        public Data() {

            Books = new List<Book>();
            Persons = new List<Person>();
            Enterprises = new List<Enterprise>();

        }

        private void CreatePerson(string name, string rut)
        {
            Person newPerson = new Person(name,rut);
            newPerson.Name = name;
            newPerson.Rut = rut;
            
            Persons.Add(newPerson);
        }

        public void Test(string name, string rut)
        {
            CreatePerson(name, rut);
            Show();
        }

        private void Show()
        {

            foreach (var list in Persons)
            {
                Console.WriteLine(list.Name + list.Rut);
            }

        }
    }
}
