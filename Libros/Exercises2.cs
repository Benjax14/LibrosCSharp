using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Libros
{
    public class Exercises2
    {

        public static List<Tuple<(string, int)>> GetBooksCountPerAuthor1(List<Book> books)
        {
            return books.GroupBy(o => o.AuthorBook.Name).Select(group => Tuple.Create((group.Key, group.Count()))).ToList();
        }


        public static List<Tuple<(Person, int)>> GetBooksCountPerAuthor2(List<Book> books)
        {
            return books.GroupBy(o => o.AuthorBook).Select(o => Tuple.Create((o.Key, o.Count()))).ToList();
        }

        public static Dictionary<string, int> GetBooksCountPerAuthor3(List<Book> books)
        {

            var list = books.GroupBy(x => x.AuthorBook.Name).ToDictionary(x => x.Key, x => x.Count());

            return list;

        }

        public static Dictionary<string, List<Book>> GetBooksIndexedByAuthor(List<Book> books)
        {
            var bookNames = books.GroupBy(x => x.AuthorBook.Name).ToDictionary(x => x.Key, x => x.ToList());

            return bookNames;

        }

        public static List<Book> LoadPageByPagination(List<Book> books, int key)
        {

            List<Book> result = new List<Book>();

            if (key == 1)
            {
                result = books.Take(5).ToList();


            }
            else if (key == 2)
            {
                result = books.Skip(5).Take(5).ToList();

            }
            else
            {
                Console.WriteLine("ERROR");
                return result;
            }

            return result;
        }

        public static List<Book> GetBooksByPage(List<Book> books, int pageIndex, int pageSize)
        {

            var startIndex = pageIndex * pageSize;

            if (startIndex >= books.Count)
            {
                Console.WriteLine("Empty");
                return new List<Book>();
            }

            var result = books.Skip(startIndex).Take(pageSize).ToList();
            return result;

        }

        public static int GetTotalPages(List<Book> books, int pageSize)
        {

            var total = books.Count();

            var totalPages = (int)Math.Ceiling((double)total / pageSize);

            return totalPages;
        }

    }
}
