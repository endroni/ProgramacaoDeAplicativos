using System;

namespace OperadorCoalescênciaNula
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            sbyte? c = null;
            double? y = 10.0;

            double a = x ?? 5;
            double b = y ?? 5;

            double d = c ?? 1;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(d);
        }
    }
}
