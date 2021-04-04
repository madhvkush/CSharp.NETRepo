using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericsDemo
{
    class Person
    {
       public string FName;
        public string LName;
    }

    class Adress
    {
        public string Distric;
        public string State;
    }
    

    class TupleDemo
    {
        public void Main()
        {
            Console.WriteLine("====Tuple Demo====");
            Tuple<int, string, string> person =
                        new Tuple<int, string, string>(1, "Steve", "Jobs");
            //OR
            //var person = Tuple.Create(1, "Steve", "Jobs");

            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
            Console.WriteLine(person.Item3);

            //Note:- A tuple can hold max 8 items
            //--------------------------------------------

            var numbers = Tuple.Create(1, 2, Tuple.Create(3, 4, 5, 6, 7, 8), 9, 10, 11, 12, 13);
            Console.WriteLine(numbers.Item1); // returns 1
            Console.WriteLine(numbers.Item2); // returns 2
            Console.WriteLine(numbers.Item3); // returns (3, 4, 5, 6, 7,  8)
            Console.WriteLine(numbers.Item3.Item1); // returns 3
            Console.WriteLine(numbers.Item4); // returns 9
            Console.WriteLine(numbers.Rest.Item1); //returns 13  --> From 8th



            Console.WriteLine("\n \n ====Value Tuple Demo==== (Access with named instances)\n");
            
                
            (Person person,Adress adres) emp = (new Person {FName="Shivam",LName="Mishra" },new Adress { State="UP",Distric="Ayodhya"});
            Console.WriteLine("Personal-Detail:- "+ emp.person.FName +" "+emp.person.LName);
            Console.WriteLine("Address-Detail:- " + emp.adres.State + " " + emp.adres.Distric);

            Console.ReadLine();


        }

        


    }
}
