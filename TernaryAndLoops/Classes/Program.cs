using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person randomPerson = new Person();
            string myName = randomPerson.name
            randomPerson.SayHello();
            randomPerson.SayHello();
        }
    }
    // Class Declaration
    // To create a speccific person, you can create an instance of the class
    class Person
    {
        readonly string MyName;
        // Getters and Settes TBD
                   
        // public name-of-the-class
        public Person(string name)
        {
            myName name = name;
        }     
        }
        // Methoid Declaration
        // access-modifer return-type name (parameters)
        // (parameters) argument1, agument2)

        public void SayHello(string str1, string str2)
        {
            Console.WriteLine("Hello");
        }

    public void SayMyName()
    {
        Console.WriteLine(myName.)();
    }
    }

}
