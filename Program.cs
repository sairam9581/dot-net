using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello world";
            string s = null ;
            int l = str.Length;
            char[] c = str.ToCharArray();
            for(int i=l-1;i>=0;i--)
            {
                Console.Write("{0}", str[i]);
                s = s + str[i];
            }
            Console.WriteLine("\n {0}",s);
        }
    }
}
