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
            CountTo10();
            Console.ReadKey();
        }
        /// <summary>
        /// Method for counting to 10
        /// </summary>
        static void CountTo10()
        {
            for(int i = 1 ; i <= 10; i++)
{
                Console.WriteLine(i);
            }
        }
    }
}
