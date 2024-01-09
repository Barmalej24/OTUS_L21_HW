using System.Diagnostics;

namespace OTUS_L21_HW
{
    internal class Fibonacci
    {
        public static int Recursion(int n)
        {
            return n > 1 ? Recursion(n - 1) + Recursion(n - 2) : n;
        }

        public static int Iteration(int n)
        {
            if (n <= 1 )
                return n;

            int _num0 = 0;
            int _num1 = 1;
            int _result = 0;
            
            for (int i = 2; i <= n; i++)
            {
                _result = _num0 + _num1;
                _num0 = _num1;
                _num1 = _result;
            }
            
            return _result;
        }
        public static (int, TimeSpan) RecursionGetTime(int number)
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            var result = Recursion(number);
            stopWatch.Stop();

            return (result, stopWatch.Elapsed);
        }

        public static (int, TimeSpan) IterationGetTime(int number)
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            var result = Iteration(number);
            stopWatch.Stop();

            return (result, stopWatch.Elapsed);
        }
    }
}
