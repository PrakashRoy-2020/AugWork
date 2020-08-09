using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPrac
{
    class GenericCollections
    {
        static void Main()
        {
            List<int> li = new List<int>();
            li.Add(20);
            li.Add(30);
            li.Add(40);
            li.Add(50);

            li.Insert(2, 35);
            foreach(int i in li)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            li.Remove(35);
            foreach (int i in li)
            {
                Console.Write(i + " ");
            }
        }
    }
}
