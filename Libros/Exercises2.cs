using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros
{
    public class Exercises2
    {

        public static void GetBooksCountPerAuthor1(List<Book> books)
        {

            var list = books.GroupBy(x => x.Author);

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key.Name}: {item.Count()}");
            }
        }

        public static void GetBooksCountPerAuthor2(List<Book> books)
        {

            var list = books.GroupBy(x => x.Author);

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key.Name}, {item.Key.Rut}: {item.Count()}");
            }

        }

        public static void GetBooksCountPerAuthor3(List<Book> books, string key)
        {

            var authorBooks = books.Where(x => x.Author.Name.Equals(key)).GroupBy(x => x.Author.Name);

            if (authorBooks.Count() > 0) { 

                foreach (var item in authorBooks)
                {
                    Console.WriteLine($"{item.Key}: {item.Count()}");
                }
            }
            else { Console.WriteLine("No result"); }
        }

        public static void GetBooksIndexedByAuthor(List<Book> books, string key)
        {
            var authorBooks = books.Where(x => x.Author.Name.Equals(key)).GroupBy(x => x.Author.Name);

            Console.WriteLine("List of books: ");

            if(authorBooks.Count() > 0) { 

                foreach(var item in authorBooks)
                {
                    foreach(var book in item)
                    {
                        Console.WriteLine(book.Name);
                    }
                }
            }else { Console.WriteLine("No result"); }
        }


    }
}
