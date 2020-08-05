using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections;

namespace CollectionsSpecializedDemo
{
    class HybridDictionaryDemo
    {
        static void Main()
        {
            HybridDictionary myDict = new HybridDictionary();

            // Adding key/value pairs in myDict 
            myDict.Add(1, "This");
            myDict.Add(2, "is");
            myDict.Add(3, "Hybrid");
            myDict.Add(4, "Dictionary");
            myDict.Add(5, "Demo");


            foreach (DictionaryEntry de in myDict)
                Console.WriteLine(de.Key + " " + de.Value);


            Console.WriteLine("------------------");
            Console.WriteLine("Total key value pairs in Hybrid Dictionary are : {0} ", myDict.Count);

            Console.WriteLine("------------------");

            Console.WriteLine("The size of Hybrid Dictionary is fixed : {0}",myDict.IsFixedSize) ;

            Console.WriteLine("---------------");


            Console.WriteLine("Hybrid Dictionary contains  4 : {0}",myDict.Contains(4));

            Console.WriteLine("------------");
            Console.WriteLine("Elements in Hybrid Dictionary :");
            IDictionaryEnumerator myEnumerator = myDict.GetEnumerator();
             while (myEnumerator.MoveNext())
                Console.WriteLine(myEnumerator.Key + "  " + myEnumerator.Value);


            Console.WriteLine("-----------");

            myDict.Remove(4);
            Console.WriteLine("Hybrid Dictionary after remove :");

            foreach (DictionaryEntry de in myDict)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }

        }
    }
}
