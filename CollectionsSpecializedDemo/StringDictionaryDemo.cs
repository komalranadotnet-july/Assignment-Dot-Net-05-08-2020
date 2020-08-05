using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections;

namespace CollectionsSpecializedDemo
{
    class StringDictionaryDemo
    {
        static void Main()
        {
            StringDictionary myDict = new StringDictionary();
            myDict.Add("One", "This");
            myDict.Add("Two", "is");
            myDict.Add("Three", "String");
            myDict.Add("Four", "Dictionary");
            myDict.Add("Five", "Demo");
            myDict.Add("Six", "using");
            myDict.Add("Seven", "System");
            myDict.Add("Eight", "Collections");
            myDict.Add("Nine", "Specialized");

            foreach (DictionaryEntry item in myDict)
            {
                Console.WriteLine("Keys : {0}  Values : {1}",item.Key,item.Value);
            }



            Console.WriteLine( "--------------");
            Console.WriteLine("Elements after copy to in myArr :");
           DictionaryEntry[] myArr = new DictionaryEntry[myDict.Count];
            myDict.CopyTo(myArr, 0);
            foreach (DictionaryEntry de in myArr)
            {
                Console.WriteLine("Keys : {0}  Values : {1}", de.Key, de.Value);
            }

            Console.WriteLine("-------------------");
            Console.WriteLine("Checks for provided key and value :");

            if (myDict.ContainsKey("Six"))
                Console.WriteLine("StringDictionary myDict contains the key");
            else
                Console.WriteLine("StringDictionary myDict does not contain the key");
            
            if (myDict.ContainsValue("Demo"))
                Console.WriteLine("StringDictionary myDict contains the value");
            else
                Console.WriteLine("StringDictionary myDict does not contain the vlaue");


            Console.WriteLine("-----------------");
            myDict.Remove("Nine");
            Console.WriteLine("Elements after Remove in StringDictionary");
            Console.WriteLine("The number of key/value pairs are : " + myDict.Count);

            foreach (DictionaryEntry a in myDict)
            {
                Console.WriteLine("Keys : {0}  Values : {1}", a.Key, a.Value);
            }



            Console.WriteLine("------------------");
            Console.WriteLine("Values in StringDictionary :");
            foreach (string val in myDict.Values)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("Keys in StringDictionary :");
            foreach (string val in myDict.Keys)
            {
                Console.WriteLine(val);
            }

}
    }
}
