using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros
{
    public class Book
    {
        public string NameBook { get; set; } //Field
        public Subject TypeBook { get; set; }
        public int PagesCount { get; set; }
        public DateTime PublicationDate { get; set; }
        public bool OnlineAvailable { get; set; }
        public Person AuthorBook { get; set; }
        public Enterprise Editorial { get; set; }

        // Constructor
        public Book(string name, Subject subject, int pages, DateTime date, bool available, Person author, Enterprise editorial)
        {
            NameBook = name;
            TypeBook = subject;
            PagesCount = pages;
            PublicationDate = date;
            OnlineAvailable = available;
            AuthorBook = author;
            Editorial = editorial;
        }


        //Imprimir generica
        public void Show()
        {
            Console.WriteLine($"{NameBook}\t{TypeBook}\t{PagesCount}\t{PublicationDate.ToString("yyyy-MM-dd")}\t{OnlineAvailable}\t{AuthorBook.Name}\t{Editorial.Name}");
        }

    }
}
