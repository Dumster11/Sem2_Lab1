using System;

namespace Lab1_2
{
    public delegate int Operation(int x, int y);
    class Program
    {
        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static int Sub(int x, int y)
        {
            return x - y;
        }
        private static int Mult(int x, int y)
        {
            return x * y;
        }
        private static int Div(int x, int y)
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            Operation op = Add;
            op += (x, y) => { return x + y; };
            Console.WriteLine("Сумма (x+y)="+op(3, 6));
            Operation op1 = Sub;
            op += (x, y) => { return x - y; };
            Console.WriteLine("Вычитание (x-y)="+op(7, 1));
            Operation op2 = Mult;
            op += (x, y) => { return x * y; };
            Console.WriteLine("Умножение (x*y)="+op(1, 9));
            Operation op3 = Div;
            op += (x, y) => { return x / y; };
            Console.WriteLine("Деление (x/y)="+op(2, 4));
            Console.ReadLine();
        }
    }
} 
