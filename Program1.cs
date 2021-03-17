using System;
using System.Collections.Generic;

namespace ConsoleApp2_1_
{
    class List
    {
        private static void Add()
        {
            var theMyLists = new List<MyList> 
            {
            new MyList() { Element = "element 3", Index = 11123},
            new MyList() { Element = "element 4", Index = 11213},
            new MyList() { Element = "element 5", Index = 11312},
            new MyList() { Element = "element 6", Index = 11321}
            };

            foreach (MyList theMyList in theMyLists)
            {
                Console.WriteLine(theMyList.Element + " index " + theMyList.Index );
            }
        }
        class MyList 
        {
            public string Element { get; set; }
            public int Index { get; set; }
        }
        static void Main(string[] args)
        {
            MyList myList1 = new MyList { Index = 12345 };
            MyList myList2 = new MyList { Index = 12435 };

            myList1.Element = "element 1";
            myList2.Element = "element 2";

            string element1 = myList1.Element;
            string element2 = myList2.Element;

            Console.WriteLine(element1);
            Console.WriteLine(element2);
            Add();
            Console.ReadKey();
        }
    }
}
