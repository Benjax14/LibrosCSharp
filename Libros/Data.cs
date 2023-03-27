using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        private void CreatePerson()
        {
            Persons.Add(new Person("Juan Perez", "12.345.678-9"));
            Persons.Add(new Person("Maria Gonzalez", "18.456.789-0"));
            Persons.Add(new Person("Pedro Ramirez", "16.345.678-1"));
            Persons.Add(new Person("Miguel de Cervantes", "1.234.423-1"));
            Persons.Add(new Person("Alberto Galindo", "20.255.234-K"));
            Persons.Add(new Person("Baldomero Lillo", "3.234.231-2"));
            Persons.Add(new Person("Aurelio Baldor", "6.231.222-8"));
            Persons.Add(new Person("Rafael Yuste", "12.345.678-9"));
            Persons.Add(new Person("Mary Jane Sterling", "15.234.764-3"));
            Persons.Add(new Person("Juan Manuel Sánchez", "12.345.678-9"));
        }

        private void CreateEnterprise()
        {
            Enterprises.Add(new Enterprise("Editorial XYZ", "12.345.678-9"));
            Enterprises.Add(new Enterprise("Editorial ABC", "98.765.432-1"));
            Enterprises.Add(new Enterprise("Editorial XYZ", "12.345.678-9"));
            Enterprises.Add(new Enterprise("Editorial PQR", "76.543.210-8"));
            Enterprises.Add(new Enterprise("Editorial ABC", "98.765.432-1"));
            Enterprises.Add(new Enterprise("Editorial XYZ", "12.345.678-9"));
            Enterprises.Add(new Enterprise("Editorial PQR", "76.543.210-8"));
            Enterprises.Add(new Enterprise("Editorial ABC", "98.765.432-1"));
            Enterprises.Add(new Enterprise("Editorial XYZ", "12.345.678-9"));
            Enterprises.Add(new Enterprise("Editorial PQR", "76.543.210-8"));

        }

        private void CreateBooks()
        {
            Books.Add(new Book("Derivadas", Subject.Maths, 200, new DateTime(2022, 07, 15), true, Persons[0], Enterprises[0]));
            Books.Add(new Book("Quimica y Farmacia 1", Subject.Chemistry, 80, new DateTime(2012, 05, 15), false, Persons[8], Enterprises[1]));
            Books.Add(new Book("Tablas quimicas", Subject.Chemistry, 300, new DateTime(2022, 03, 25), true, Persons[3], Enterprises[2]));
            Books.Add(new Book("Don Quijote", Subject.Literature, 250, new DateTime(2022, 01, 05), true, Persons[3], Enterprises[3]));
            Books.Add(new Book("Fundamentos Quimica", Subject.Chemistry, 180, new DateTime(2021, 03, 11), true, Persons[2], Enterprises[4]));
            Books.Add(new Book("Subterra", Subject.Literature, 220, new DateTime(2020, 02, 20), false, Persons[4], Enterprises[5]));
            Books.Add(new Book("Baldor", Subject.Maths, 170, new DateTime(2019, 09, 25), true, Persons[6], Enterprises[5]));
            Books.Add(new Book("La quimica del amor", Subject.Chemistry, 280, new DateTime(2023, 01, 29), false, Persons[9], Enterprises[6]));
            Books.Add(new Book("Matematicas for dummies", Subject.Maths, 200, new DateTime(2018, 02, 14), false, Persons[5], Enterprises[7]));
            Books.Add(new Book("Nomenclatura de las sustancias químicas", Subject.Chemistry, 190, new DateTime(2014, 05, 25), true, Persons[7], Enterprises[8]));


        }


        public void Poblate()
        {
            CreatePerson();
            CreateEnterprise();
            CreateBooks();
        }

        public void Test()
        {
            Show();
        }

        private void Show()
        {

            Console.WriteLine("Books List: ");

            foreach (var book in Books) {

                Console.WriteLine($"{book.Name}\t{book.Subject}\t{book.Pages}\t{book.Date.ToString("yyyy-MM-dd")}\t{book.Available}\t{book.Author.Name}\t{book.Editorial.Name}");


            }

        }
    }
}
