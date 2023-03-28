using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros
{

    public class Exercises1 { 

    //Muestra los libros de matematicas
    public static void GetMaths(List<Book> books)
    {
        Console.WriteLine("Maths books: ");
        foreach (Book book in books.Where(book => book.TypeBook == Subject.Maths))
        {
            book.Show();
        }
    }

    //Muestra los libros de quimica que tiene mas de 100 paginas
    public static void GetChemistry(List<Book> books)
    {
        Console.WriteLine("Chemistry books that have more than 100 pages: ");
        foreach (Book book in books.Where(book => book.TypeBook == Subject.Chemistry && book.PagesCount > 100))
        {

            book.Show();

        }
    }


    //Muestra la cantidad de paginas en total entre todos los libros
    public static void GetNumberPages(List<Book> books)
    {
        var count = 0;

        count = books.Sum(book => book.PagesCount);

        Console.WriteLine("Total pages:");
        Console.WriteLine($"{count}");

    }

    //Muestra todos los libros ordenados desde el que tiene más páginas al que tiene menos páginas

    public static void OrderBooksPages(List<Book> books)
    {
        var list = books.OrderByDescending(book => book.PagesCount);

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
            int count = books.Count(b => b.TypeBook == subject);
            Console.WriteLine($"{subject}\t{count}");
        }


    }

    public static void CountBooksBySpecialty2(List<Book> books)
    {

        var list = books.GroupBy(book => book.TypeBook);
        Console.WriteLine("Number of books by specialty: ");

        foreach (var group in list)
        {
            Console.WriteLine($"{group.Key}: {group.Count()}");
        }

    }

    //Muestra el libro que tenga la mayor cantidad de páginas
    public static Book GetMaxPagesBook(List<Book> books)
    {

        var query = books.OrderByDescending(book => book.PagesCount).FirstOrDefault();


        return query;

    }

    //Muestra el libro más antiguo con la fecha de publicación más antigua
    public static Book GetOlderBook(List<Book> books)
    {
        var query = books.OrderBy(book => book.PublicationDate).FirstOrDefault();

        return query;
    }

    public static void GetActualMonthBooks(List<Book> books)
    {

        var localDate = DateTime.Now;

        var list = books.Where(book => book.PublicationDate.Month == localDate.Month);

        Console.WriteLine("Order by actual month: ");

        foreach (Book book in list)
        {
            book.Show();
        }
    }

    public static List<string> GetSortedBookNames(List<Book> books)
    {

        List<string> names = books.Select(o => o.NameBook).ToList();

        names.Sort();

        return names;
    }
    }
}
