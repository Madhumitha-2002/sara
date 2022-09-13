using System;

namespace Day_5
{
    class Program
    {
        abstract class abc
        {
            abstract public void print();
            public void show()
            {
                Console.WriteLine("asdasd");
            }
        }
        class ABC2 : abc
        {
            int a = 5;
            int b = 5;
            public override void print()
            {
                Console.WriteLine("I am print Method");
            }
            public override string ToString()
            {
                return "a= " + a + "b= " + b;
            }

        }
        class Class1
        {
            public static void Main1()
            {
                ABC2 abc = new ABC2();
                string sampl = abc.ToString();
                Console.WriteLine(sampl);
            }
        }
    }
}
  
