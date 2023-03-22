using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Libros.Program;

namespace Libros
{
    public class Book
    {
        private string name;
        private Subject subject;
        private int pages;
        private DateTime date;
        private bool available;

        // Constructor
        public Book(string name, Subject subject, int pages, DateTime date, bool available)
        {
            this.name = name;
            this.subject = subject;
            this.pages = pages;
            this.date = date;
            this.available = available;
            GetSubjects = subject;
        }


        //Imprimir generica
        public void Show()
        {
            Console.WriteLine($"{name}\t{subject}\t{pages}\t{date.ToString("yyyy-MM-dd")}\t{available}");
        }

        public Subject GetSubjects { get; }
        public string GetName { get { return name; } }
        public int GetPages { get { return pages; } }
        public DateTime GetDate { get { return date; } }
        public bool GetAvailable { get; } 

    }
}
