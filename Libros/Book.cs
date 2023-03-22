using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros
{
    public class Book
    {
        public string name { get; } //Field
        public Subject subject { get; }
        public int pages { get; }
        public DateTime date { get; }
        public bool available { get; }

        // Constructor
        public Book(string name, Subject subject, int pages, DateTime date, bool available)
        {
            this.name = name;
            this.subject = subject;
            this.pages = pages;
            this.date = date;
            this.available = available;
            //GetSubjects = subject;
        }


        //Imprimir generica
        public void Show()
        {
            Console.WriteLine($"{name}\t{subject}\t{pages}\t{date.ToString("yyyy-MM-dd")}\t{available}");
        }

        //public Subject GetSubjects { get; }
        //public string GetName { get { return name; } }
        //public int GetPages { get { return pages; } }
        //public DateTime GetDate { get { return date; } }
        //public bool GetAvailable { get; } 

    }
}
