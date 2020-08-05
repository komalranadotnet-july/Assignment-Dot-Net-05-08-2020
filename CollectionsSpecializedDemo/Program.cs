using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Dynamic;

namespace CollectionsSpecializedDemo
{
    class Program
    {
        static void Main()
        {
            StringCollection sc = new StringCollection();
            sc.Add("This ");
            sc.Add("is ");
            sc.Add("String ");
            sc.Add("Collection");
            sc.Add("using");
            sc.Add("System ");
            sc.Add("Collections ");
            sc.Add("Specialized ");
           

            Console.WriteLine("Elements in String Collection :");
            StringEnumerator se = sc.GetEnumerator();

            while (se.MoveNext())
            {
                Console.WriteLine(se.Current);
            }
           Console.WriteLine("-------------------");

            
            Console.WriteLine("Output using Insert :");
            sc.Insert(3, "Value inserted at index 3");
             StringEnumerator se1 = sc.GetEnumerator();

            while (se1.MoveNext())
            {
                Console.WriteLine(se1.Current);
            }


            
            Console.WriteLine("-------------------");
            Console.WriteLine("The collection contains USING : {0}",sc.Contains("using"));


            
            Console.WriteLine("--------------------");
            Console.WriteLine("After removing String:");
            sc.Remove("Value inserted at index 3");
            StringEnumerator se3 = sc.GetEnumerator();
             while (se3.MoveNext())
            {
                Console.WriteLine(se3.Current);
            }


            
            Console.WriteLine("--------------------");

            Console.WriteLine("After removing from indesx 3:");

            sc.RemoveAt(3);
            StringEnumerator se4 = sc.GetEnumerator();
            while (se4.MoveNext())
            {
                Console.WriteLine(se4.Current);
            }


            Console.WriteLine("--------------------");
            Console.WriteLine("Elements after Add Range :");

            String[] myArr = new String[] { "This","is","Add", "Range", "Example" };
            sc.AddRange(myArr);
            StringEnumerator se5 = sc.GetEnumerator();
            while (se5.MoveNext())
            {
                Console.WriteLine(se5.Current);
            }


            Console.WriteLine("---------------");
            Console.WriteLine("Output of Contains and IndexOf");

            if (sc.Contains("Range"))
                Console.WriteLine("The collection contains Range at index {0}.", sc.IndexOf("Range"));
            else
                Console.WriteLine("The collection does not contain Range.");
 }
    }
}
