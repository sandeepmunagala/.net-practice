using System;
using CollectionsNew;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsNew
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);//0
            al.Add("amazon");
           // al.Add("bazaar");
             //   al.Add("costco");
            Console.WriteLine(al.Capacity);//4. by default after adding the first element the size will be preserved to 4.
            al.TrimToSize();
            Console.WriteLine(al.Capacity);//3
            al.Add("dmart");
            int i = al.Count;//returns the value of number of elements in arraylist 
            Console.WriteLine(i);
            string a = al[1].ToString();

            Console.WriteLine(a);
            Console.WriteLine();
            al.Sort();
            //al.Reverse();
            foreach (String s1 in al)
                Console.WriteLine(s1);
            Console.WriteLine(al.Capacity);//since initailly it was 3now it get doubled to 6 
            al.Insert(2, "ebay");//to insert an element in middle of an array
            foreach (String s2 in al)
                Console.WriteLine(s2);
            Console.WriteLine();
            al.Remove("ebay");//remove an object directly
            foreach (String s3 in al)
                Console.WriteLine(s3);
            Console.WriteLine();
            al.RemoveAt(2);//rempove an element based on index value
            foreach (String s4 in al)
                Console.WriteLine(s4);
            Console.WriteLine();
            al.RemoveRange(0, 2);//remove elements by giving range
            foreach (String s5 in al)
                Console.WriteLine(s5);

        }
    }
}
