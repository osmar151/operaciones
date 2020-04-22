using System;

namespace operaciones
{
    class Program
    {
        static void Main(string[] args)
        {

            int op = 0;
            char menu = 'n';
            double n1 = 0;
            double n2 = 0;
            double total = 0;
            string linea = "";

            while (menu!= 's')
            {
                Console.WriteLine("1.-suma");
                Console.WriteLine("2.-resta");
                Console.WriteLine("3.-multiplicacion");
                Console.WriteLine("4.-division");
                Console.WriteLine("5.-salir");
                Console.WriteLine("opcion: ");

                linea = Console.ReadLine();
                op = int.Parse(linea);


                Console.WriteLine("ingrese el primer valor: ");
                linea = Console.ReadLine();
                n1 = int.Parse(linea);

                Console.WriteLine("ingrese el segundo valor: ");
                linea = Console.ReadLine();
                n2 = int.Parse(linea);

               
            }





        }
    }
}
