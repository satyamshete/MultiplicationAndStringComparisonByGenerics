namespace Multiply_StringCompare_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Write interger number multiplication , float number multiplication and compare the string must be in upper case only then refactor code by using generic method

            MultiplicationByGenerics multiplicationByGenerics = new MultiplicationByGenerics();

            Console.WriteLine("Press 1 for intiger Multiplication without generics");
            Console.WriteLine("Press 2 for float Multiplication without generics");
            Console.WriteLine("Press 3 for intiger Multiplication with generics");
            Console.WriteLine("Press 4 for float Multiplication with generics");
            Console.WriteLine("Press 5 for Strings compare without generics");
            Console.WriteLine("Press 6 for Strings compare with generics");

            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    multiplicationByGenerics.IntMultplication();
                    break;
                case 2:
                    multiplicationByGenerics.FloatMultplication();
                    break;
                case 3:
                    Console.WriteLine("Enter first Number");
                    int FNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter secod Number");
                    int SNum = int.Parse(Console.ReadLine());
                    multiplicationByGenerics.MultiplyByGenerics<int>(FNum, SNum);
                    break;
                case 4:
                    Console.WriteLine("Enter first Number");
                    float Fnum = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter secod Number");
                    float Snum = float.Parse(Console.ReadLine());
                    multiplicationByGenerics.MultiplyByGenerics<float>(Fnum, Snum);
                    break;
                case 5:
                    CompareStrings compareStringsOne = new CompareStrings();
                    compareStringsOne.CompareString();
                    break;
                case 6:
                    CompareStrings compareStringsTwo = new CompareStrings();
                    Console.WriteLine("Enter first String");
                    String first = (Console.ReadLine());
                    Console.WriteLine("Enter secod String");
                    String second = (Console.ReadLine());
                    compareStringsTwo.CompareStringByGenerics(first, second);
                    break;
                default:
                    Console.WriteLine("Make Proper Seection");
                    break;
            }
        }
    }
}