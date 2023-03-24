using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros
{
    public class Book
    {
        public string Name { get; set; } //Field
        public Subject Subject { get; set; }
        public int Pages { get; set; }
        public DateTime Date { get; set; }
        public bool Available { get; set; }
        public Person Author { get; set; }
        public Enterprise Editorial { get; set; }

        // Constructor
        public Book(string name, Subject subject, int pages, DateTime date, bool available, Person author, Enterprise editorial)
        {
            Name = name;
            Subject = subject;
            Pages = pages;
            Date = date;
            Available = available;
            Author = author;
            Editorial = editorial;
        }


        //Imprimir generica
        public void Show()
        {
            Console.WriteLine($"{Name}\t{Subject}\t{Pages}\t{Date.ToString("yyyy-MM-dd")}\t{Available}\t{Author.Name}\t{Editorial.Name}");
        }

    }
}
