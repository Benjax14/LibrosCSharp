using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Xml.Linq;

namespace Libros
{
    internal class Program
    {

        //populate
        //public static List<Book> CreateBooks()
        //{

        //    List<Book> books = new List<Book>();

        //    books.Add(new Book("Derivadas", Subject.Maths, 200, new DateTime(2022, 07, 15), true, new Person("Juan Perez", "12.345.678-9"), new Enterprise("Editorial XYZ", "12.345.678-9")));
        //    books.Add(new Book("Quimica y Farmacia 1", Subject.Chemistry, 80, new DateTime(2012, 05, 15), false, new Person("Maria Gonzalez", "18.456.789-0"), new Enterprise("Editorial ABC", "98.765.432-1")));
        //    books.Add(new Book("Tablas quimicas", Subject.Chemistry, 300, new DateTime(2022, 03, 25), true, new Person("Pedro Ramirez", "16.345.678-1"), new Enterprise("Editorial XYZ", "12.345.678-9")));
        //    books.Add(new Book("Don Quijote", Subject.Literature, 250, new DateTime(2022, 01, 05), true, new Person("Miguel de Cervantes", ""), new Enterprise("Editorial PQR", "76.543.210-8")));
        //    books.Add(new Book("Fundamentos Quimica", Subject.Chemistry, 180, new DateTime(2021, 03, 11), true, new Person("Alberto Galindo", ""), new Enterprise("Editorial ABC", "98.765.432-1")));
        //    books.Add(new Book("Subterra", Subject.Literature, 220, new DateTime(2020, 02, 20), false, new Person("Baldomero Lillo", ""), new Enterprise("Editorial XYZ", "12.345.678-9")));
        //    books.Add(new Book("Baldor", Subject.Maths, 170, new DateTime(2019, 09, 25), true, new Person("Aurelio Baldor", ""), new Enterprise("Editorial PQR", "76.543.210-8")));
        //    books.Add(new Book("La quimica del amor", Subject.Chemistry, 280, new DateTime(2023, 01, 29), false, new Person("Rafael Yuste", "12.345.678-9"), new Enterprise("Editorial ABC", "98.765.432-1")));
        //    books.Add(new Book("Matematicas for dummies", Subject.Maths, 200, new DateTime(2018, 02, 14), false, new Person("Mary Jane Sterling", ""), new Enterprise("Editorial XYZ", "12.345.678-9")));
        //    books.Add(new Book("Nomenclatura de las sustancias químicas", Subject.Chemistry, 190, new DateTime(2014, 05, 25), true, new Person("Juan Manuel Sánchez", "12.345.678-9"), new Enterprise("Editorial PQR", "76.543.210-8")));

        //    return books;
        //}

        //Muestra los libros de matematicas
        public static void GetMaths(List<Book> books)
        {
            Console.WriteLine("Maths books: ");
            foreach (Book book in books.Where(book => book.Subject == Subject.Maths))
            {
                book.Show();
            }
        }

        //Muestra los libros de quimica que tiene mas de 100 paginas
        public static void GetChemistry(List<Book> books)
        {
            Console.WriteLine("Chemistry books that have more than 100 pages: ");
            foreach (Book book in books.Where(book => book.Subject == Subject.Chemistry && book.Pages > 100))
            {

                book.Show();

            }
        }


        //Muestra la cantidad de paginas en total entre todos los libros
        public static void GetNumberPages(List<Book> books)
        {
            var count = 0;

            count = books.Sum(book => book.Pages);

            Console.WriteLine("Total pages:");
            Console.WriteLine($"{count}");

        }

        //Muestra todos los libros ordenados desde el que tiene más páginas al que tiene menos páginas

        public static void OrderBooksPages(List<Book> books)
        {
            var list = books.OrderByDescending(book => book.Pages);

            Console.WriteLine("Order by pages: ");

            foreach (Book book in list)
            {
                book.Show();
            }
        }

        //Muestra cuántos libros hay por cada especialidad, considerando que en un futuro podrían agregar especialidades(podrían agregar items al enum) 
        public static void CountBooksBySpecialty(List<Book> books)
        {
            var subjectTypes = Enum.GetValues(typeof(Subject));
            Console.WriteLine("Number of books by specialty: ");

            foreach (Subject subject in subjectTypes)
            {
                int count = books.Count(b => b.Subject == subject);
                Console.WriteLine($"{subject}\t{count}");
            }


        }

        public static void CountBooksBySpecialty2(List<Book> books)
        {

            var list = books.GroupBy(book => book.Subject);
            Console.WriteLine("Number of books by specialty: ");

            foreach (var group in list)
            {
                Console.WriteLine($"{group.Key}: {group.Count()}");
            }

        }

        //Muestra el libro que tenga la mayor cantidad de páginas
        public static Book GetMaxPagesBook(List<Book> books)
        {

            var query = books.OrderByDescending(book => book.Pages).FirstOrDefault();
                

            return query;

        }

        //Muestra el libro más antiguo con la fecha de publicación más antigua
        public static Book GetOlderBook(List<Book> books)
        {
            var query = books.OrderBy(book => book.Date).FirstOrDefault();

            return query;
        }

        public static void GetActualMonthBooks(List<Book> books)
        {

            var localDate = DateTime.Now;

            var list = books.Where(book => book.Date.Month == localDate.Month);

            Console.WriteLine("Order by actual month: ");

            foreach (Book book in list)
            {
                book.Show();
            }
        }

        public static List<string> GetSortedBookNames(List<Book> books)
        {
         
            List<string> names = books.Select(o => o.Name).ToList();

            names.Sort();

            return names;
        }

        static void Main(string[] args)
        {

            var books = new List<Book>();

            var dataPerson = new Data();

            dataPerson.Test("Pepe", "20.551.932-3");


            //books = CreateBooks();

            Console.WriteLine("------WELCOME-----");
            Console.WriteLine("Choose an option: \n" +
                "1.- All math books\n" +
                "2.- All Chemistry books that have more than 100 pages \n" +
                "3.- The book with the most pages \n" +
                "4.- The oldest book with the oldest publication date \n" +
                "5.- The total number of pages among all the books \n" +
                "6.- Shows all the books ordered from the one with the most pages to the one with the fewest pages \n" +
                "7.- Shows how many books there are for each specialty \n" +
                "8.- Shows list of names of books published this month \n" +
                "9.- List of names of all books, ordered from A to Z \n"+
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
                    Book topBook = GetMaxPagesBook(books);
                    topBook.Show();
                    break;

                case 4:

                    Console.WriteLine("The oldest book: ");
                    Book olderBook = GetOlderBook(books);
                    olderBook.Show();
                    break;

                case 5:

                    GetNumberPages(books);
                    break;

                case 6:

                    OrderBooksPages(books);
                    break;

                case 7:
                    CountBooksBySpecialty2(books);
                    //CountBooksBySpecialty(Books);
                    break;
                case 8:
                    GetActualMonthBooks(books);
                    break;
                case 9:
                    var sortedBooks = GetSortedBookNames(books);
                    Console.WriteLine("Sorted books:");
                    foreach (string bookName in sortedBooks)
                    {
                        Console.WriteLine(bookName);
                    }
                    break;
                case 0:
                    break;
            }


            //foreach (Book book in books)
            //{
            //    Console.WriteLine($"{book.Name}\t{book.Subject}\t{book.Pages}\t{book.Date.ToString("yyyy-MM-dd")}\t{book.Available}");

            //}
            Console.ReadKey();
        }


    }

}