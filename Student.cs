using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Student
    {
        static void Main(string[] args)
        {
            // Creating a list of strings  
            var stuNames = new List<string>();
            stuNames.Add("Ragini");
            stuNames.Add("Ragini Ragini");
            stuNames.Add("Ragini Singh");
            stuNames.Add("R Singh");

            // Iterating list element using foreach loop  
            foreach (var stuName in stuNames)
            {
                Console.WriteLine(stuName);
            }
        }
    }
}



