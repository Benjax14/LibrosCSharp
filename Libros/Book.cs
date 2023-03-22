using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Libros.Program;

namespace Libros
{
    internal class Books
    {
        public class Book
        {
            private string Name;
            private Subjects Subject;
            private int Pages;
            private DateTime Date;
            private bool Available;

            // Constructor
            public Book(string name, Subjects subject, int pages, DateTime date, bool available)
            {
                this.Name = name;
                this.Subject = subject;
                this.Pages = pages;
                this.Date = date;
                this.Available = available;
            }


            //Imprimir generica
            public void Show()
            {
                Console.WriteLine($"{Name}\t{Subject}\t{Pages}\t{Date.ToString("yyyy-MM-dd")}\t{Available}");
            }

            public Subjects GetSubjects { get; }
            public String Getname { get; }
            public int GetPages { get; }
            public DateTime GetDate { get; }
            public bool GetAvailable { get; } 

        }
    }
}
