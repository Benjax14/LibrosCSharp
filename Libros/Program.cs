using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace Libros
{
    internal class Program
    {

        static void Main(string[] args)
        {

            var data = new Data();

            data.Poblate();
           // data.Test();


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
                "0.- Next");

            int option = Convert.ToInt32(Console.ReadLine());


            Console.Clear();

            switch (option)
            {

                case 1:

                    Exercises1.GetMaths(data.Books);
                    
                    break;

                case 2:

                    Exercises1.GetChemistry(data.Books);
                    break;

                case 3:

                    Console.WriteLine("The book with the most pages: ");
                    Book topBook = Exercises1.GetMaxPagesBook(data.Books);
                    topBook.Show();
                    break;

                case 4:

                    Console.WriteLine("The oldest book: ");
                    Book olderBook = Exercises1.GetOlderBook(data.Books);
                    olderBook.Show();
                    break;

                case 5:

                    Exercises1.GetNumberPages(data.Books);
                    break;

                case 6:

                    Exercises1.OrderBooksPages(data.Books);
                    break;

                case 7:

                    Exercises1.CountBooksBySpecialty2(data.Books);
                    break;

                case 8:

                    Exercises1.GetActualMonthBooks(data.Books);
                    break;
                case 9:

                    var sortedBooks = Exercises1.GetSortedBookNames(data.Books);
                    Console.WriteLine("Sorted books:");
                    foreach (string bookName in sortedBooks)
                    {
                        Console.WriteLine(bookName);
                    }
                    break;
                case 0:
                    Console.Clear();
                    break;
            }

            Console.WriteLine("Choose an option: \n" +
               "1.- List of tuples showing the number of books by author\n" +
               "2.- List of tuples showing the number of books by author name\n" +
               "3.- Search the number of books by author selected by keyboard\n"+
               "4.- Search the name of the books by author");

            option = Convert.ToInt32(Console.ReadLine());
            
            switch (option)
            {
                case 1:
                    var prueba = Exercises2.GetBooksCountPerAuthor1(data.Books);
                    
                    foreach ((string, int) bookName in prueba) {  Console.WriteLine(bookName); }

                    break;
                case 2:
                    Exercises2.GetBooksCountPerAuthor2(data.Books);
                    break;

                case 3:
                    Console.WriteLine("Insert author:");
                    string key1 = Console.ReadLine();
                    var prueba3 = Exercises2.GetBooksCountPerAuthor3(data.Books, key1);

                    foreach (var item in prueba3)
                    {
                        Console.WriteLine($"{item}");
                    }

                    break;
                case 4:

                    Console.WriteLine("Insert author:");

                    string key2 = Console.ReadLine();
                    var prueba4 = Exercises2.GetBooksIndexedByAuthor(data.Books, key2);
                    Console.Clear();


                    foreach(var item in prueba4) {  
                        Console.WriteLine($"{item.Key}:");
                        foreach(var bookName in item.Value)
                        {
                            Console.WriteLine($"  {bookName.NameBook}");
                        }
                    }

                    break;
            }


            Console.ReadKey();
        }


    }

}