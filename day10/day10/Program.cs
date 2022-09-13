using System;

namespace day10
{
    class Class1
    {
        static int Sum(int x, int y)
        {
            return (x + y);
        }
        static void Print(int i)
        {
            Console.WriteLine(i);
        }
        static bool IsPostiveNumber(int val)
        {
            if (val > 0)
            {
                return true;
            }
            else
                return false;
        }
        public static void Main()
        {
            Func<int, int, int> add = Sum;
            int result = add(10, 10);
            Console.WriteLine(result);
            Action<int> printVal = Print;
            printVal(10);
            Predicate<int> predicate = IsPostiveNumber;
            Console.WriteLine(predicate(1));
        }
    }
}


