using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPrac
{
    //GenericDelegate
    //1.Func<input params/output params>
    //2.Action<only input params/output void>
    //3.Predicate<one param only/output bool value>
    
    
    class GenericDelegate
    {
        public static int Add(int a,int b,int c)
        {
            return a + b + c;
        }
        public static void Add2(int a, int b, int c)
        {
            Console.WriteLine(a+b+c);
        }
        public static bool Add3(string s)
        {
            if (s.Length > 5)
                return true;
            return false;
        }
        static void Main()
        {
            Func<int, int, int, int> obj1 = Add;
            var add=Add(1,2,3);
            Console.WriteLine(add);

            Action<int, int, int> obj2 = Add2;
            Add2(1,2,3);

            Predicate<string> obj3 = Add3;
            var res = Add3("hello");
            Console.WriteLine(res);
        }
    }
}
