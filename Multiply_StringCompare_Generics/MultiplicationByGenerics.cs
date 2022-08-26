using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_StringCompare_Generics
{
    internal class MultiplicationByGenerics
    {

        internal void IntMultplication()
        {
            Console.WriteLine("Enter first Number");
            int FNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter secod Number");
            int SNumber = int.Parse(Console.ReadLine());
            int Multiplication = FNumber * SNumber;

            Console.WriteLine("Multiplication Valus is :" + Multiplication);
        }
        internal void FloatMultplication()
        {
            Console.WriteLine("Enter first Number");
            float FNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter secod Number");
            float SNumber = float.Parse(Console.ReadLine());
            float Multiplication = FNumber * SNumber;

            Console.WriteLine("Multiplication Valus is :" + Multiplication);
        }
        internal void MultiplyByGenerics<T>(T fNumber, T sNumber)
        {
            float FNumber = float.Parse(fNumber.ToString());
            float SNumber = float.Parse(sNumber.ToString());
            float Multiplication = FNumber * SNumber;
            Console.WriteLine("Multiplication Valus is :" + Multiplication);
        }
    }
}
