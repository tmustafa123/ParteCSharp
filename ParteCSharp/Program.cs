using System;
namespace ParteCSharp
{


    public class Program
    {
        const string PIPPO = "Pippo";
        const string PLUTO = "Pluto";
        const string PAPERINO = "Paperino";
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number x");
            var x = Console.ReadLine();
            
            Console.WriteLine("Enter the number y");
            var y = Console.ReadLine();

            if (!string.IsNullOrEmpty(x) && !string.IsNullOrEmpty(y))
            {
                PrintCharacterName(Convert.ToInt16(x), Convert.ToInt16(y));
                Console.ReadLine();
            }     


        }

        public static bool IsPowerOfTwo(int n)
        {
            if (n == 0)
                return false;

            return (Math.Ceiling(Math.Log2(n)) == Math.Floor(Math.Log2(n)));
        }

        public static void PrintCharacterName(int startNum, int endNum)
        {
            var minNum = endNum > startNum ? startNum : endNum;
            var maxNum = endNum > startNum ? endNum : startNum;
            var num = minNum;
            
            while (true)
            {
                if(IsPowerOfTwo(num)) {
                    Console.WriteLine(PAPERINO);
                    return;
                }
                if (num % 2 == 0)
                    Console.WriteLine(PIPPO);
                if(num % 3 == 0)
                    Console.WriteLine(PLUTO);

                num += 1;
                if (num > maxNum)
                    return;
            }
        }
    }
}
