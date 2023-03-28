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
            return books.GroupBy(o => o.AuthorBook)
                        .Select(o => Tuple.Create((o.Key, o.Count())))
                        .ToList();
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
