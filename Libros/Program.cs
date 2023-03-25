using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Xml.Linq;

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
                "0.- Exit");

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
                    break;
            }


            Console.ReadKey();
        }


    }

}