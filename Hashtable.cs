using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int key;
            string value;
            Hashtable ht = new Hashtable();//should store key-value pairs
            ht.Add(1, "one");
            ht.Add(4, "two");
            ht.Add(6, "six");
            ht.Add(8, "eight");
            ht.Add(10, "aero");
            
            Console.WriteLine(ht.IsFixedSize);
            foreach (DictionaryEntry de in ht) {//each key value pair will be stored as a combined unit in DE.
                key = (int)de.Key;
                value = de.Value.ToString();
                Console.WriteLine(key+ " " +value);
                    }

            if (ht.Contains(11))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            //foreach (Object s in ht.Keys)
            //    Console.WriteLine(s);
            //foreach (object v in ht.Values)
            //    Console.WriteLine(v);
            ht.Remove(1);
            foreach (object b in ht.Keys)
                Console.WriteLine(b);

            
        }
    }
}
