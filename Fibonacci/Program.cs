using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            String userNumber;
            int n;
            Console.WriteLine("Insira um número inteiro");
            userNumber = Console.ReadLine();
            n = Convert.ToInt32(userNumber);

            Console.WriteLine("------------");
            Console.WriteLine(Fibonacci(n));
            Console.ReadLine();
        }
        /// <summary>
        /// Method for calculating the nth number of fibonacci sequence
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int Fibonacci(int n)
        {
            int resultado = 0;

            if (n <= 2)
                resultado = 1;
            else
                resultado = Fibonacci(n - 1) + Fibonacci(n - 2);
            return resultado;
        }
    }
}
