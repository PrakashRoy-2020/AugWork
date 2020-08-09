using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPrac
{
    class Generic1
    {
        public bool Compare<T>(T a,T b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }
        static void Main()
        {
            Generic1 gn = new Generic1();
            bool result=gn.Compare<int>(10, 10);
            //bool result = gn.Compare(10, 20);
            Generic1 gn1 = new Generic1();
            bool result1 = gn.Compare<float>(10.0f, 11.0f);
            Console.WriteLine(result);
            Console.WriteLine(result1);
        }
    }
}
