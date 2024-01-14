using System.Diagnostics;

namespace OTUS_L21_HW
{
    internal class Fibonacci
    {
        public static int GetFibonaciNumberRecursive(int n)
        {
            return n > 1 ? GetFibonaciNumberRecursive(n - 1) + GetFibonaciNumberRecursive(n - 2) : n;
        }

        public static int GetFibonaciNumber(int n)
        {
            if (n <= 1 )
                return n;

            var _num0 = 0;
            var _num1 = 1;
            var _result = 0;
            
            for (int i = 2; i <= n; i++)
            {
                _result = _num0 + _num1;
                _num0 = _num1;
                _num1 = _result;
            }
            
            return _result;
        }
        public static (int, TimeSpan) GetRecursionTime(int number)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            var result = GetFibonaciNumberRecursive(number);
            stopWatch.Stop();

            return (result, stopWatch.Elapsed);
        }

        public static (int, TimeSpan) GetIterationTime(int number)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            var result = GetFibonaciNumber(number);
            stopWatch.Stop();

            return (result, stopWatch.Elapsed);
        }
    }
}
