using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project18
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList objSL = new SortedList();
            objSL.Add("4", "!");
            objSL.Add("3", "Brilliant");
            objSL.Add("2", "am");
            objSL.Add("1", "I");
            Console.WriteLine("Number of Elements in objSL : {0}", objSL.Count);
            Console.WriteLine("\t-KEY-\t-VALUE-");
            for(int i = 0; i < objSL.Count; i++)
            {
                Console.WriteLine("\t{0}:\t{1}", objSL.GetKey(i), objSL.GetByIndex(i));
            }
            Console.ReadLine();
        }
    }
}
