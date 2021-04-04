using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //dynamically load an assembly in our main application program.
            Assembly myAssembly = Assembly.LoadFile(@"D:\WorkSpace\TestCalc\bin\Debug\TestCalc.dll");  // Give the coorect location

            //Get type of object from loaded assembly

            Type myType = myAssembly.GetType("TestCalc.Calculator");
            object objInstance = Activator.CreateInstance(myType);
            Type objectType = objInstance.GetType();

            // you can also load get the type form Instnace of any class.

            //TestCalc.Calculator calc = new TestCalc.Calculator();         
            //Type objectType = calc.GetType();
            

           

            Console.WriteLine("========Properties=======");
            foreach (PropertyInfo objMemberInfo in objectType.GetProperties())
            {

                Console.WriteLine(objMemberInfo.Name);

            }

            Console.WriteLine("========Methods=======");
            foreach (MethodInfo objMemberInfo in objectType.GetMethods())
            {

                Console.WriteLine(objMemberInfo.Name);

            }

            // To Get all Props, Methods and fileds
            //foreach (MemberInfo objMemberInfo in objectType.GetMembers())
            //{

            //    Console.WriteLine(objMemberInfo.Name);

            //}
            Console.ReadLine();
        }
    }
}
