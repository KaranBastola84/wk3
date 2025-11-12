using wk3gnment.wk3;
using System;

namespace wk3gnment
{
    class Program
    {
        static void Main(string[] args)
        {
            Operators t1 = new();
            t1.GetInput();
            t1.Add();
            t1.Subtract();
            t1.Multiply();
            t1.Divide();
            t1.OddEvenFinder();
        }
    }
}