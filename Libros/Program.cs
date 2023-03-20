using System.Collections;

namespace Libros
{
    internal class Program
    {
        enum Subjects { Matematicas, Lenguaje, Quimica };

        static void postBook (ArrayList Books) 
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

            ArrayList Book = new ArrayList();

            Book.Add(Name);
            Book.Add(Subject);
            Book.Add(Pages);

            Books.Add(Book);

        }

        static void Output(ArrayList arrayList)
        {
            foreach (ArrayList Books in arrayList)
            {

                foreach (object item in Books)
                {
                    Console.WriteLine(item);
                }
            }
        }

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


            Console.WriteLine("La cantidad de libros es: {0}", Cant);

            ArrayList Books = new ArrayList();

            for(int i = 0;i < Cant; i++) {

                postBook(Books);

            }
            
            Output(Books);


        }


    }

}