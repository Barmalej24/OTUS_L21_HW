using System.Text;

namespace OTUS_L21_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Рекурсия");
            //Console.WriteLine(Fibonacci.Recursion(5));
            //Console.WriteLine(Fibonacci.Recursion(10));
            //Console.WriteLine(Fibonacci.Recursion(20));

            //Console.WriteLine("Цикл");
            //Console.WriteLine(Fibonacci.Iteration(5));
            //Console.WriteLine(Fibonacci.Iteration(10));
            //Console.WriteLine(Fibonacci.Iteration(20));

            Console.WriteLine("Рекурсия");
            PrintResult(Fibonacci.GetRecursionTime(5));
            PrintResult(Fibonacci.GetRecursionTime(10));
            PrintResult(Fibonacci.GetRecursionTime(20));

            Console.WriteLine("Цикл");
            PrintResult(Fibonacci.GetIterationTime(5));
            PrintResult(Fibonacci.GetIterationTime(10));
            PrintResult(Fibonacci.GetIterationTime(20));
        }

        static void PrintResult((int, TimeSpan) result)
        {
            var st = new StringBuilder();

            st.AppendLine($"Член последовательности равный {result.Item1} найден за {result.Item2.TotalMicroseconds} микросекунд");

            Console.WriteLine(st);
        }        
    }
}
