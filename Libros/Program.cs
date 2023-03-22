﻿using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using static Libros.Program;

namespace Libros
{
    internal class Program
    {
        static List<Book> books;

        public class Book
        {
            public string Name { get; set; }
            public Subjects Subject { get; set; }
            public int Pages { get; set; }
            public DateTime Date { get; set; }
            public bool Available { get; set; }


            public Book(string name, Subjects subject, int pages, DateTime date, bool available)
            {
                Name = name;
                Subject = subject;
                Pages = pages;
                Date = date;
                Available = available;
            }

            public void Show()
            {
                Console.WriteLine($"{Name}\t{Subject}\t{Pages}\t{Date.ToString("yyyy-MM-dd")}\t{Available}");
            }
        }
        public enum Subjects { Maths, Literature, Chemistry };
        public static List<Book> CreateBooks()
        {

            books.Add(new Book ( "Libro1", Subjects.Maths, 200, new DateTime(2022, 07, 15), true ));
            books.Add(new Book ("Libro2", Subjects.Chemistry, 80 ,new DateTime(2012, 05, 15),false ));
            books.Add(new Book ("Libro3", Subjects.Literature, 300, new DateTime(2022, 03, 25), true));
            books.Add(new Book ("Libro4", Subjects.Literature, 250, new DateTime(2022, 01, 05), true));
            books.Add(new Book ("Libro5", Subjects.Maths, 180, new DateTime(2021, 03, 11), true));
            books.Add(new Book ("Libro6", Subjects.Maths, 220, new DateTime(2020, 02, 20), false));
            books.Add(new Book ("Libro7", Subjects.Chemistry, 170, new DateTime(2019, 09, 25), true));
            books.Add(new Book ("Libro8", Subjects.Literature, 280, new DateTime(2023, 01, 29), false));
            books.Add(new Book ("Libro9", Subjects.Literature, 200, new DateTime(2018, 02, 14), false));
            books.Add(new Book ("Libro10", Subjects.Maths, 190, new DateTime(2014, 05, 25), true));

            return books;
        }


        public static void GetMaths(List<Book> books)
        {
            Console.WriteLine("Los libros de matematicas");
            foreach (Book book in books.Where(book => book.Subject == Subjects.Maths))
            {
                Console.WriteLine($"{book.Name}");
            }
        }

        public static void GetChemistry(List<Book> books)
        {
            Console.WriteLine("Los libros de quimica que tiene mas 100 paginas");
            foreach (Book book in books.Where(book => book.Subject == Subjects.Chemistry && book.Pages > 100))
            {

                Console.WriteLine($"{book.Name}\t{book.Pages}");

            }
        }

        //Muestra el libro que tenga la mayor cantidad de páginas
        public static Book GetMayorPages()
        {

            Book match = null; 

            foreach (Book book in books)
            {
                if(match == null)
                {
                    match = book;
                }
                else if(match.Pages < book.Pages)
                { 
                    match = book;
                }
            }

            return match;

        }

        //Muestra el libro más antiguo (con la fecha de publicación más antigua
        public static Book GetOlderBook()
        {
            Book match = null;

            foreach(Book book in books)
            {
                if(match == null) { 
                    match= book;
                }else if (match.Date > book.Date)
                {
                    match = book;
                }
            }

            return match;
        }
        public static void GetNumberPages(List<Book> books)
        {
            var count = 0;
            foreach(Book book in books)
            {
                count = count + book.Pages;
            }

            Console.WriteLine(count);
        }

        //Muestra todos los libros ordenados desde el que tiene más páginas al que tiene menos páginas

        public static void OrderBooksPages(List<Book> books)
        {
            List<Book> list = books.OrderByDescending(book => book.Pages).ToList();

            foreach (Book book in list)
            {
                book.Show();
            }
        }

        //Muestra cuántos libros hay por cada especialidad, considerando que en un futuro podrían agregar especialidades(podrían agregar items al enum) 
        public static void CountBooksBySpecialty(List<Book> books)
        {
            var subjectTypes = Enum.GetValues(typeof(Subjects));
            Console.WriteLine("Cantidad de libros por especialidad: ");

            foreach (Subjects subject in subjectTypes)
            {
                int count = books.Count(b => b.Subject == subject);
                Console.WriteLine($"{subject}: {count}");
            }


        }

        static void Main(string[] args)
        {

            books = new List<Book>();

            books = CreateBooks();

            Book topBook = GetMayorPages();
            Book olderBook= GetOlderBook();

            //OrderBooksPages(books);

            CountBooksBySpecialty(books);

            //foreach (Book book in books)
            //{
            //    Console.WriteLine($"{book.Name}\t{book.Subject}\t{book.Pages}\t{book.Date.ToString("yyyy-MM-dd")}\t{book.Available}");

            //}


            //Console.WriteLine("El libro mas viejo: ");
            //olderBook.Show();


            //Console.WriteLine("El libro con mayor cantidad de paginas: ");
            //topBook.Show();

            //GetMayorPages(books);

            //GetNumberPages(books);

            //GetMaths(books);

            //GetChemistry(books);


        }


    }

}