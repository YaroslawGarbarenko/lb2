using System;

namespace ConsoleApp2._4
{
    class Program
    {
        public class MyClass
        {
            public int Val { get; set; }
            public MyClass(int i)
            {
                Val = i;
            }
            public MyClass() { }
        }
        static void Main(string[] args)
        {
            MyClass obj = MyFactory<MyClass>.FacrotyMethod();


            Console.ReadKey();

        }
    }

    public class MyFactory<T> where T : new()
    {
        public static T FacrotyMethod()
        {
            return new T();
        }
    }

    public class MyClass
    {
        public int Val { get; set; }
        public MyClass(int i)
        {
            Val = i;
        }
    }
}
