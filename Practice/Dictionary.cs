using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPrac
{
    class Dictionary
    {
        static void Main()
        {
            Dictionary<string, object> dt = new Dictionary<string, object>();
            dt.Add("id", 1);
            dt.Add("name", "prakash");
            dt.Add("salary", 25000);
            dt.Add("city", "pune");

            foreach(var i in dt.Keys)
            {
                Console.WriteLine(i+":"+dt[i]);
            }
        }
    }
}
