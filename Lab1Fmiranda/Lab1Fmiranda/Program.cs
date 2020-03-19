using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Fmiranda
{
    class Program
    {
        static void Main(string[] args)
        {
            //creando con constructor que recibe parametros
            Console.WriteLine("Constructor que recibe parámetos");
            Person p1 = new Person(33,"Bob","Kunga");
            //Console.WriteLine(p1);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Lastname1);

            Console.WriteLine("   ");

            // creando objeto con constructor vacio me tira los atributos por defecto 
            Console.WriteLine("Constructor vacio que lanza parametros por default"); 
            Person p2 = new Person();
            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.Lastname1);

            Console.WriteLine("      ");

            Console.WriteLine("Metodo Lanzar");
            p1.Throw();
        }
    }
}
