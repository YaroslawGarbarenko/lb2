using System;
using System.Collections.Generic;

namespace ConsoleApp2._2
{
  
    class Dictionary
    {
        private static void Add()
        {
            var theMyDictionar = new List<MyDictionary<string>>
            {
            new MyDictionary<string>() { Element = "element 3", Index = 11123},
            new MyDictionary<string>() { Element = "element 4", Index = 11213},
            new MyDictionary<string>() { Element = "element 5", Index = 11312},
            new MyDictionary<string>() { Element = "element 6", Index = 11321}
            };

            foreach (MyDictionary<string> theMyDictionars in theMyDictionar)
            {
                Console.WriteLine(" Index " + theMyDictionars.Index + " " + theMyDictionars.Element);
            }
        }
        class MyDictionary<T>
        {
            public T Element { get; set; }
            public int Index { get; set; }

        }
        static void Main(string[] args)
        {
            MyDictionary<int> myDctionary1 = new MyDictionary<int> {Element = 1};
            MyDictionary<int> myDctionary2 = new MyDictionary<int> {Element = 2};

            myDctionary1.Index = 12345;
            myDctionary2.Index = 12435;

            int index1 = myDctionary1.Index;
            int index2 = myDctionary2.Index;

            Console.WriteLine(index1);
            Console.WriteLine(index2);
            Add();
            Console.ReadKey();
        }   
    }
    
}
