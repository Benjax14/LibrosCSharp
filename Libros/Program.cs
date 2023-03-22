using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using static Libros.Program;

namespace Libros
{
    internal class Program
    {
        //lista global
        static List<Book> books;

        public class Book
        {
            public string Name { get; set; }
            public Subjects Subject { get; set; }
            public int Pages { get; set; }
            public DateTime Date { get; set; }
            public bool Available { get; set; }

            //Constructor
            public Book(string name, Subjects subject, int pages, DateTime date, bool available)
            {
                Name = name;
                Subject = subject;
                Pages = pages;
                Date = date;
                Available = available;
            }

            //Imprimir generica
            public void Show()
            {
                Console.WriteLine($"{Name}\t{Subject}\t{Pages}\t{Date.ToString("yyyy-MM-dd")}\t{Available}");
            }

            public void ShowSubject(Subjects Subject,int count)
            {
                Console.WriteLine($"{Subject}\t{count}");
            }

            public void ShowPages(int count)
            {
                Console.WriteLine("Total pages:");
                Console.WriteLine($"{count}");
            }
        }

        // Enum type para las asignaturas/especialidad
        public enum Subjects { Maths, Literature, Chemistry };

        //populate
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

        //Muestra los libros de matematicas
        public static void GetMaths(List<Book> books)
        {
            Console.WriteLine("Maths books: ");
            foreach (Book book in books.Where(book => book.Subject == Subjects.Maths))
            {
                book.Show();
            }
        }

        //Muestra los libros de quimica que tiene mas de 100 paginas
        public static void GetChemistry(List<Book> books)
        {
            Console.WriteLine("Chemistry books that have more than 100 pages: ");
            foreach (Book book in books.Where(book => book.Subject == Subjects.Chemistry && book.Pages > 100))
            {

                book.Show();

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

        //Muestra el libro más antiguo con la fecha de publicación más antigua
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

        //Muestra la cantidad de paginas en total entre todos los libros
        public static void GetNumberPages(List<Book> books)
        {
            var count = 0;
            foreach(Book book in books)
            {
                count = count + book.Pages;
            }

            Book total = books[0];
            total.ShowPages(count);

        }

        //Muestra todos los libros ordenados desde el que tiene más páginas al que tiene menos páginas

        public static void OrderBooksPages(List<Book> books)
        {
            List<Book> list = books.OrderByDescending(book => book.Pages).ToList();

            Console.WriteLine("Order by pages: ");

            foreach (Book book in list)
            {
                book.Show();
            }
        }

        //Muestra cuántos libros hay por cada especialidad, considerando que en un futuro podrían agregar especialidades(podrían agregar items al enum) 
        public static void CountBooksBySpecialty(List<Book> books)
        {
            var subjectTypes = Enum.GetValues(typeof(Subjects));
            Console.WriteLine("Number of books by specialty: ");

            Book book = books[0];

            foreach (Subjects subject in subjectTypes)
            {
                int count = books.Count(b => b.Subject == subject);
                book.ShowSubject(subject,count);
            }


        }

        static void Main(string[] args)
        {

            books = new List<Book>();

            books = CreateBooks();

            Console.WriteLine("------WELCOME-----");
            Console.WriteLine("Choose an option: \n" +
                "1.- All math books\n" +
                "2.- All Chemistry books that have more than 100 pages \n" +
                "3.- The book with the most pages \n" +
                "4.- The oldest book with the oldest publication date \n" +
                "5.- The total number of pages among all the books \n" +
                "6.- Shows all the books ordered from the one with the most pages to the one with the fewest pages \n" +
                "7.- Shows how many books there are for each specialty \n" +
                "0.- Exit");

            int option = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (option)
            {

                case 1:

                    GetMaths(books);
                    break;

                case 2:

                    GetChemistry(books);
                    break;

                case 3:

                    Console.WriteLine("The book with the most pages: ");
                    Book topBook = GetMayorPages();
                    topBook.Show();
                    break;

                case 4:

                    Console.WriteLine("The oldest book: ");
                    Book olderBook = GetOlderBook();
                    olderBook.Show();
                    break;

                case 5:

                    GetNumberPages(books);
                    break;

                case 6:

                    OrderBooksPages(books);
                    break;

                case 7:

                    CountBooksBySpecialty(books);
                    break;

                case 0:
                    break;
            }


            //foreach (Book book in books)
            //{
            //    Console.WriteLine($"{book.Name}\t{book.Subject}\t{book.Pages}\t{book.Date.ToString("yyyy-MM-dd")}\t{book.Available}");

            //}

            Thread.Sleep(10000);

            Environment.Exit(0);
        }


    }

}