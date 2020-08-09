using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(20);
            ar.Add(30);
            ar.Add(40);
            foreach(var i in ar)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            ar.Insert(2, 35);
            foreach (var i in ar)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            ar.Remove(35);
            foreach (var i in ar)
            {
                Console.Write(i+" ");
            }
        }
    }
}
