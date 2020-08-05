using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections;

namespace CollectionsSpecializedDemo
{
    class ListDictionaryDemo
    {
        static void Main()
        {
            
            ListDictionary myDict = new ListDictionary();

             
            myDict.Add(1, "This");
            myDict.Add(2, "is");
            myDict.Add(3, "List");
            myDict.Add(4, "Dictionary");
            myDict.Add(5, "Demo");

            Console.WriteLine("Elements in List Dictionary :");
            
            foreach (DictionaryEntry de in myDict)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }



            Console.WriteLine("-----------------");
            Console.WriteLine("Total key value  in myDict are : " + myDict.Count);

            Console.WriteLine("-----------------");

            Console.WriteLine("Keys in List Dictionary :");

            ICollection ic = myDict.Keys;
             foreach (var v in ic)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("----------------");
            Console.WriteLine("Values in List Dictionary :");

            ICollection value = myDict.Values;

            foreach (var v in value)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("Output for Contains");
            Console.WriteLine(myDict.Contains(4));

            Console.WriteLine("-------------");
            Console.WriteLine("After Removing a particular key :");

            myDict.Remove(1);

            foreach (DictionaryEntry de in myDict)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }

            Console.WriteLine("-------------");
            myDict.Clear();

            Console.WriteLine("Total key value pairs in myDict are : " + myDict.Count);






        }
    }
}
