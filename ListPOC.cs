using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class ListPOC
    {
        public static void Main(String[] args)
        {
            List<int> listfirst = new List<int>();

            listfirst.Add(1);
            listfirst.Add(2);
            listfirst.Add(3);
            listfirst.Add(4);

           Console.WriteLine("Capacity of firstlist is: " + listfirst.Capacity);

            Console.WriteLine("Count of firstlist is: " + listfirst.Count);
        
            // Adding some more elements in firstlist
            listfirst.Add(5);
            listfirst.Add(6);

            Console.WriteLine("Capacity of firstlist is: " + listfirst.Capacity);

            Console.WriteLine("Count of firstlist is: " + listfirst.Count);
        }
    }
}

