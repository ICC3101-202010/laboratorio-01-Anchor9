using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Fmiranda
{
    public class Person
    {
        private int age = 55;
        private string name = "Albert";
        private string lastname = "Einstein";


        //Constructor

        public Person(int Age, string Name, string Lastname)

        {
            // CONSTRUCTOR --> (atributo = parametro)
            age = Age;
            name = Name;
            lastname = Lastname;


        
        }

        public Person()
        {

        }

        public string Name { get => name; set => name = value; }
        public string Lastname1 { get => lastname; set => lastname = value; }



        //Metodo lanzar
        public void Throw()
        {
            Random random = new Random();
            //for (int i = 0; i < 3; i++)

            int i = random.Next(0, 3); 
                     
            if (i == 0)
                {
                Console.WriteLine("piedra");
                Console.WriteLine(i);
            }
            else if (i == 1)
                {
                Console.WriteLine("Papel", i);
                Console.WriteLine(i);
            }
            else if (i == 2)
                {
                Console.WriteLine("Tijera",i);
                Console.WriteLine(i);
            }


        }
        //public string Getname()
        //{
        //    return name;
        //}

    }
}
