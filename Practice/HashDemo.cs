using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsPrac
{
    class HashDemo
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("id",1);
            ht.Add("name","prakash");
            ht.Add("salary",25000);
            ht.Add("city","pune");

            Console.WriteLine(ht["name"]);

            foreach(Object key in ht.Keys)
            {
                Console.WriteLine(key+":"+ht[key]);
            }

        }
    }
}
