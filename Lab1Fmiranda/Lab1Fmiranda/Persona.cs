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

        public void Throw()
        {
            
        
        }
        //public string Getname()
        //{
        //    return name;
        //}

    }
}
