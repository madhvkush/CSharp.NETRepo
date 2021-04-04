using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateUseCase
{
    class DelegateAsCallback
    {
        public delegate void PrintHandler(string str);

        public void Print(string str)
        {
            Console.WriteLine(str);
        }

        public void Add(int a, int b , PrintHandler printHandler)
        {
            int result = a + b;
            printHandler("Addition:- " +result.ToString()); 
        }

        public void Sub(int a, int b, PrintHandler printHandler)
        {
            int result = a - b;
            printHandler("Subtraction:- "+result.ToString());
        }


        public void Main()
        {
            Console.WriteLine("Enter Two numbers a, b to perform Add and Subtraction");
            Console.WriteLine("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b=");
            int b = Convert.ToInt32(Console.ReadLine());

            Add(a, b, Print); // Passing Method as parameter == CALLBACK   --> Here Print is passed as callback method
            Sub(a, b, Print);
        }
    }
}
