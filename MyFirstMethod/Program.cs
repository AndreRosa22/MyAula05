using System;

namespace MyFirstMethod
{
    class Program
    {
        /// <summary>
        /// Main method, runs all other methods
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("----CounTo10----");
            CountTo10();
            Console.WriteLine("----CounToN----");
            CountToN(10);
            Console.WriteLine("----CounToN----");
            CountToN(10);
            Console.ReadKey();
        }
        /// <summary>
        /// Method for counting from 1 to 10
        /// </summary>
        static void CountTo10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Method for counting from 1 to n
        /// </summary>
        /// <param name="n"></param>
        static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }


    }
}
