using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPrac
{
    //<modifier>delegate<keyword> void/type<return type> <name>(<param>);
    public delegate void AddDel(int a, int b);
    public delegate string SayDel(string name);
    class DelegatesPrac
    {
        public void AddNum(int a ,int b)
        {
            Console.WriteLine(a+b);
        }
        
        public static string SayHello(string name)
        {
            return "hello" + name;
        }
        static void Main()
        {
            DelegatesPrac dp = new DelegatesPrac();

            AddDel ad = new AddDel(dp.AddNum);
            ad(100, 5);

            SayDel sd = new SayDel(SayHello);
            var res=sd(" Prakash");
            Console.WriteLine(res);

        }
    }
}
