using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros
{
    public class Exercises2
    {

        public static Tuple<(string authorName, int bookCount)[]> GetBooksCountPerAuthor1(List<Book> books)
        {
            var result = books.GroupBy(b => b.AuthorBook.Name).Select(g => (AuthorName: g.Key, BookCount: g.Count())).ToArray();

            return Tuple.Create(result);

        }




        public static Tuple<(string author, int bookCount)[]> GetBooksCountPerAuthor2(List<Book> books)
        {

            var result = books.GroupBy(b => b.AuthorBook.Name).Select(o =>  (author: o.Key, BookCount: o.Count())).ToArray();
            return Tuple.Create(result);

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


    }
}
