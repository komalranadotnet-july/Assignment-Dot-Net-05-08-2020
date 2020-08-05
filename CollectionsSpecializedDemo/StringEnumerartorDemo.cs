using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;


namespace CollectionsSpecializedDemo
{
    class StringEnumerartorDemo
    {
        static void Main()
        {
            StringCollection mySEnum = new StringCollection();
            mySEnum.Add("This");
            mySEnum.Add("is");
            mySEnum.Add("String");
            mySEnum.Add("Enumerator");
            mySEnum.Add("Demo");
           

            // Enumerates the elements in the StringCollection.
            StringEnumerator myEnumerator = mySEnum.GetEnumerator();
            while (myEnumerator.MoveNext())
                Console.WriteLine("{0}", myEnumerator.Current);
            Console.WriteLine();

            //// Resets the enumerator and displays the first element again.
            myEnumerator.Reset();
            if (myEnumerator.MoveNext())
              Console.WriteLine("The first element is {0}.", myEnumerator.Current);
        }
    }
}
