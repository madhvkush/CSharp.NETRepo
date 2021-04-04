using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateUseCase
{
    class DelegateAsAnonymous
    {
        public delegate void Calculation(int a, int b);

        public void Main()
        {
            Console.WriteLine("Enter Two numbers a, b to perform Add and Subtraction");
            Console.WriteLine("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b=");
            int b = Convert.ToInt32(Console.ReadLine());

            Calculation calc = delegate (int x, int y) { Console.WriteLine("Addition:- " + (a + b)); }; // calc --> is pointing unnamed method (anonymous method)

            calc +=  (int x, int y) => { Console.WriteLine("Subtration:- " + (a - b)); };  // multicast delegate --> pointing to another anonymous method

            calc(a,b); // invoke --> it will call both anonymous method 

        }

        // Tow ways of declaration of anonymous method
        // 1:- using 'delegate' keyword     Line-21
        // 2:- using lambda operator '=>'    Line-23
    }
}
