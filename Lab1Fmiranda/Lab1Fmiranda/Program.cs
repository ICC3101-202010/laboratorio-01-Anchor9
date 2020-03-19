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

            Person p1 = new Person(33,"Juan","Munoz");
            //Console.WriteLine(p1);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Lastname1);

            // creando objeto con constructor vacio

            Person p2 = new Person();
            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.Lastname1);

        }
    }
}
