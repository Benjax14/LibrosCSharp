namespace Libros
{
    internal class Program
    {

        public class Book
        {
            public string Name;
            public Subjects Subject;
            public int Pages;
            public DateTime Date;
            public bool Available;

        }
        public enum Subjects { Maths, Literature, Chemistry };

        public static List<Book> CreateBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { Name = "Libro1", Subject = Subjects.Maths, Pages = 200, Date = new DateTime(2022, 07, 15), Available = true });
            books.Add(new Book { Name = "Libro2", Subject = Subjects.Chemistry, Pages = 80, Date = new DateTime(2012, 05, 15), Available = false });
            books.Add(new Book { Name = "Libro3", Subject = Subjects.Literature, Pages = 300 ,Date = new DateTime(2022, 03, 25), Available = true });
            books.Add(new Book {Name = "Libro4", Subject = Subjects.Literature, Pages = 250, Date = new DateTime(2022, 01, 05), Available = true });
            books.Add(new Book {Name = "Libro5", Subject = Subjects.Maths, Pages = 180, Date = new DateTime(2021, 03, 11), Available = true });
            books.Add(new Book {Name = "Libro6", Subject = Subjects.Maths, Pages = 220, Date = new DateTime(2020, 02, 20), Available = false });
            books.Add(new Book {Name = "Libro7", Subject = Subjects.Chemistry, Pages = 170, Date = new DateTime(2019, 09, 25), Available = true });
            books.Add(new Book {Name = "Libro8", Subject = Subjects.Literature, Pages = 280, Date = new DateTime(2023, 01, 29), Available = false });
            books.Add(new Book {Name = "Libro9", Subject = Subjects.Literature, Pages = 200, Date = new DateTime(2018, 02, 14), Available = false });
            books.Add(new Book {Name = "Libro10", Subject = Subjects.Maths, Pages = 190, Date = new DateTime(2014, 05, 25), Available = true });

            return books;
        }
        static void Show(List<Book> Books)
        {
           
            foreach (Book book in Books)
            {
                Console.WriteLine($"{book.Name}\t{book.Subject}\t{book.Pages}\t{book.Date.ToString("yyyy-MM-dd")}\t{book.Available}");
            }
        }


        public static void GetMaths(List<Book> books)
        {
            Console.WriteLine("Los libros de matematicas");
            foreach (Book book in books.Where(book => book.Subject == Subjects.Maths))
            {
                Console.WriteLine($"{book.Name}");
            }
        }

        public static void GetChemistry(List<Book> books)
        {
            Console.WriteLine("Los libros de quimica que tiene mas 100 paginas");
            foreach (Book book in books.Where(book => book.Subject == Subjects.Chemistry && book.Pages > 100))
            {

                Console.WriteLine($"{book.Name}\t{book.Pages}");

            }
        }

        public static void GetNumberPages(List<Book> books)
        {
            var count = 0;
            foreach(Book book in books)
            {
                count = count + book.Pages;
            }

            Console.WriteLine(count);
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

            var books = new List<Book>();

            books = CreateBooks();

            //Show(books);
            GetNumberPages(books);
            //GetMaths(books);
            //Console.WriteLine("\n");
            //GetChemistry(books);


        }


    }

}