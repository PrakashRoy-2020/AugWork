using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace CollectionsPrac
{
    class LinqPrac
    {
       static void Main()
        {
            int[] arr = { 12, 43, 76, 56, 32, 10, 23, 50, 90 };
            var brr = from it in arr
                      where it >= 40 && it%2==0
                      orderby it descending
                      select it;
            foreach (int i in brr)
            {
                Console.Write(i+" ");
            }
        }
	
            


    }
}
