using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_StringCompare_Generics
{
    internal class CompareStrings
    {
        internal void CompareString()
        {
            CompareStrings compareStringsOne = new CompareStrings();
            Console.WriteLine("Enter first String");
            String first = (Console.ReadLine());
            Console.WriteLine("Enter secod String");
            String second = (Console.ReadLine());
            string First = Convert.ToString(first).ToUpper();
            string Second = Convert.ToString(second).ToUpper();

            if (First == Second)
            {
                Console.WriteLine("Strings are equal");
            }
            else
            {
                Console.WriteLine("Strings are not equal");
            }
        }
        internal void CompareStringByGenerics<T>(T first, T second)
        {
            string First = Convert.ToString(first).ToUpper();
            string Second = Convert.ToString(second).ToUpper();
            if (First == Second)
            {
                Console.WriteLine("Strings are equal");
            }
            else
            {
                Console.WriteLine("Strings are not equal");
            }
        }
    }
}
