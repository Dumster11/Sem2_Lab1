using System;

namespace Lab1_1
{
    public delegate int Sr_ar(int x, int y, int z);
    class Program
    {
        private static int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        static void Main(string[] args)
        {
            Sr_ar operation = Add;
            operation += delegate (int x, int y, int z) { return (x + y + z) / 3; };
            Console.WriteLine(operation(6, 1, 7));
            Console.ReadKey();

        }
    }
}
