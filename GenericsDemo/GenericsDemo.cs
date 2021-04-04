using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    interface IMyInterface
    {

    }
    class MyClass
    {

    }
    struct MyStruct
    {

    }

    class DataStore<T> where T : class
    {
        public T Data { get; set; }
    }

    class DataStore2<T> where T : class, new()
    {
        public T Data { get; set; }
    }
    class DataStore3<T> where T : struct
    {
        public T Data { get; set; }
    }
    
    class GenericsDemo
    {
        public void Main()
        {
            //=============DataStore===================
            DataStore<string> store = new DataStore<string>(); // valid
            DataStore<MyClass> store1 = new DataStore<MyClass>(); // valid
            DataStore<IMyInterface> store2 = new DataStore<IMyInterface>(); // valid
            DataStore<IEnumerable> store3 = new DataStore<IEnumerable>(); // valid
            DataStore<ArrayList> store4 = new DataStore<ArrayList>(); // valid
            //DataStore<int> store = new DataStore<int>(); // compile-time error 

            //=========================DataStore2=================

            DataStore2<MyClass> store5 = new DataStore2<MyClass>(); // valid
            DataStore2<ArrayList> store6 = new DataStore2<ArrayList>(); // valid
            //DataStore2<string> store343 = new DataStore2<string>(); // compile-time error 
            //DataStore2<int> store = new DataStore2<int>(); // compile-time error 
            //DataStore2<IMyInterface> store = new DataStore2<IMyInterface>(); // compile-time error

            //=========================DataStore3=================

            DataStore3<int> store7 = new DataStore3<int>(); // valid
            DataStore3<char> store8 = new DataStore3<char>(); // valid
            DataStore3<MyStruct> store9 = new DataStore3<MyStruct>(); // valid
            //DataStore3<string> store = new DataStore3<string>(); // compile-time error 

            Console.ReadLine();
        }

        // you can pass more then one Type like below
        class Employee<TPrersonl, TOfficial, TSalary> where TPrersonl : class where TOfficial : class where TSalary : struct
        {
            public TPrersonl Personal { get; set; }
            public TOfficial Official { get; set; }
            public TSalary Salary { get; set; }
        }

    }
}
