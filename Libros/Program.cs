using System.Collections;

namespace Libros
{
    internal class Program
    {
        enum Subjects { Matematicas, Lenguaje, Quimica };

        static void postBook (List<Object> Books) 
        {

            string Name;
            Subjects Subject;
            int Pages;

            string flag;
            string Option;

            Console.WriteLine("Ingrese el nombre del libro: ");
            Name = Console.ReadLine();

            Console.WriteLine("Seleccione la especialidad: \n1.- Matematicas\n2.- Lenguaje\n3.- Quimica");
            Option= Console.ReadLine();

            if (Option == "1")
            {
                Subject = Subjects.Matematicas;
            }else if (Option == "2")
            {
                Subject = Subjects.Lenguaje;
            }
            else
            {
                Subject= Subjects.Quimica;
            }

            Console.WriteLine("Ingrese la cantidad de páginas: ");

            do
            {
                flag = Console.ReadLine();
                Pages = Convert.ToInt32(flag);

            } while (Pages <= 49);

            List<object> Book = new List<Object>();

            Book.Add(Name);
            Book.Add(Subject);
            Book.Add(Pages);

            Books.Add(Book);

        }

        static void Output(List<Object> Books)
        {
            foreach (List<Object> Book in Books)
            {
                
                foreach (object item in Book)
                {
                    Console.WriteLine(item);
                }
            }
        }


        public static void Maths(List<Object> lista)
        {

            foreach (List<Object> Books in lista)
            {
                var res = Books.ToArray().Where(book => book.Equals(Subjects.Matematicas));

                foreach (object item in res)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        //public static void Maths(List<object> lista)
        //{
        //    foreach (List<object> Books in lista)
        //    {
        //        var res = Books.ToArray()
        //                       .Where(book => book.GetType().GetProperty("Subject")?.GetValue(book) is Subjects s && s.HasFlag(Subjects.Matematicas))
        //                       .Select(book => book.GetType().GetProperty("Pages")?.GetValue(book));

        //        foreach (object item in res)
        //        {
        //            Console.WriteLine(item);
        //        }
        //    }
        //}

        static void Main(string[] args)
        {


            string val;
            int Cant;


            do
            {

                Console.WriteLine("Ingrese la cantidad de libros");
                val = Console.ReadLine();
                Cant = Convert.ToInt32(val);

            } while (Cant <= 0);


            Console.WriteLine("La cantidad de libros es: {0}\n", Cant);

            List<object> Book = new List<Object>();

            for(int i = 0;i < Cant; i++) {

                postBook(Book);

            }
            
            //Output(Book);
            Maths(Book);


        }


    }

}