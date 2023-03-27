using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros
{
    public class Exercises2
    {

        public static List<(string authorName, int bookCount)> GetBooksCountPerAuthor1(List<Book> books)
        {

            var list = books.GroupBy(x => x.Author.Name).Select(o => (authorName: o.Key, bookCount: o.Count())).ToList();

            return list;   
        }

        public static void GetBooksCountPerAuthor2(List<Book> books)
        {

            var list = books.GroupBy(x => x.Author);

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key.Name}, {item.Key.Rut}: {item.Count()}");
            }

        }

        public static Dictionary<string, int> GetBooksCountPerAuthor3(List<Book> books, string key)
        {

            var list = books.Where(x => x.Author.Name.Equals(key)).GroupBy(x => x.Author.Name).ToDictionary(x => x.Key, x => x.Count());

            return list;

        }

        public static Dictionary<string, List<Book>> GetBooksIndexedByAuthor(List<Book> books, string key)
        {
            var bookNames = books.Where(x => x.Author.Name.Equals(key)).GroupBy(x => x.Author.Name).ToDictionary(x => x.Key, x => x.ToList());

            return bookNames;

        }


    }
}
