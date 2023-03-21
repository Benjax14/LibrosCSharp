using System.Collections;

namespace Libros
{
    internal class Program
    {

        public class Book{
            public string Name;
            public Subjects Subject;
            public int Pages;

        }
        public enum Subjects { Matematicas, Lenguaje, Quimica };

        //static void postBook (List<Object> Books) 
        //{

        //    string Name;
        //    Subjects Subject;
        //    int Pages;

        //    string flag;
        //    string Option;

        //    Console.WriteLine("Ingrese el nombre del libro: ");
        //    Name = Console.ReadLine();

        //    Console.WriteLine("Seleccione la especialidad: \n1.- Matematicas\n2.- Lenguaje\n3.- Quimica");
        //    Option= Console.ReadLine();

        //    if (Option == "1")
        //    {
        //        Subject = Subjects.Matematicas;
        //    }else if (Option == "2")
        //    {
        //        Subject = Subjects.Lenguaje;
        //    }
        //    else
        //    {
        //        Subject= Subjects.Quimica;
        //    }

        //    Console.WriteLine("Ingrese la cantidad de páginas: ");

        //    do
        //    {
        //        flag = Console.ReadLine();
        //        Pages = Convert.ToInt32(flag);

        //    } while (Pages <= 49);

        //    List<object> Book = new List<Object>();

        //    Book.Add(Name);
        //    Book.Add(Subject);
        //    Book.Add(Pages);

        //    Books.Add(Book);

        //}

        public static List<Book> CreateBooks()
        {
            List<Book> books = new List<Book>();

            books.Add(new Book { Name = "Libro1", Subject = Subjects.Matematicas, Pages = 200 });
            books.Add(new Book { Name = "Libro2", Subject = Subjects.Quimica, Pages = 80 });
            books.Add(new Book { Name = "Libro3", Subject = Subjects.Lenguaje, Pages = 300 });
            books.Add(new Book { Name = "Libro4", Subject = Subjects.Lenguaje, Pages = 250 });
            books.Add(new Book { Name = "Libro5", Subject = Subjects.Matematicas, Pages = 180 });
            books.Add(new Book { Name = "Libro6", Subject = Subjects.Matematicas, Pages = 220 });
            books.Add(new Book { Name = "Libro7", Subject = Subjects.Quimica, Pages = 170 });
            books.Add(new Book { Name = "Libro8", Subject = Subjects.Lenguaje, Pages = 280 });
            books.Add(new Book { Name = "Libro9", Subject = Subjects.Lenguaje, Pages = 200 });
            books.Add(new Book { Name = "Libro10", Subject = Subjects.Matematicas, Pages = 190 });

            return books;
        }
        static void Output(List<Book> Books)
        {
            foreach (Book book in Books)
            {
                Console.WriteLine($"Nombre: {book.Name}, Especialidad: {book.Subject}, Paginas: {book.Pages}");
            }
        }


        public static void Maths(List<Book> Books)
        {
            Console.WriteLine("Los libros de matematicas");
            foreach (Book book in Books.Where(book => book.Subject == Subjects.Matematicas))
            {
                Console.WriteLine($"Nombre: {book.Name}");
            }
        }

        public static void Chemistry(List<Book> Books)
        {
            Console.WriteLine("Los libros de quimica que tiene mas 100 paginas");
            foreach (Book book in Books.Where(book => book.Subject == Subjects.Quimica && book.Pages > 100)){

                Console.WriteLine($"Nombre: {book.Name}, Paginas: {book.Pages}");

            }
        }

        static void Main(string[] args)
        {


            //string val;
            //int Cant;


            //do
            //{

            //    Console.WriteLine("Ingrese la cantidad de libros");
            //    val = Console.ReadLine();
            //    Cant = Convert.ToInt32(val);

            //} while (Cant <= 0);


            //Console.WriteLine("La cantidad de libros es: {0}\n", Cant);

            var Book = new List<Book>();

            Book = CreateBooks();

            //Output(Book);
            Maths(Book);
            Console.WriteLine("\n");
            Chemistry(Book);


        }


    }

}