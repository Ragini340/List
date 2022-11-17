using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class RemoveElementAtSpecifiedIndex
    {
        public static void Main(String[] args)
        {
           List<int> firstlist = new List<int>();

            firstlist.Add(10);
            firstlist.Add(11);
            firstlist.Add(12);
            firstlist.Add(13);
            firstlist.Add(14);
            firstlist.Add(15);
            firstlist.Add(16);

            Console.WriteLine("Elements present in the List are :\n");

            int p = 0;

            foreach (int k in firstlist)
            {
                Console.Write("Element at position {0}: ", p);
                Console.WriteLine(k);
                p++;
            }

            Console.WriteLine(" ");

            // Here removing the element at index 3
            Console.WriteLine("Removing the element at index 3\n");

            //Here 9 will remove from the List and 75 will come at index 3
            firstlist.RemoveAt(3);

            int p1 = 0;

            // Displaying the elements of List
            foreach (int n in firstlist)
            {
                Console.Write("Element at position {0}: ", p1);
                Console.WriteLine(n);
                p1++;
            }
        }
    }
}

