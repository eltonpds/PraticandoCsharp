using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
    internal class Program
    {
        //C# 9
        static async Task Main(string[] args)
        {
            await _callMethod();

            Console.ReadKey();
        }

        private static async Task _callMethod()
        {
            Method2();
            var count = await Method1();
            Method3(count);
        }

        public static async Task<int> Method1()
        {
            int count = 0;

            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Method 1: i {0}", i);
                    count += 1;
                }
            });

            return count;
        }

        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Method 2: i {0}", i);
            }
        }

        public static void Method3(int count)
        {
            Console.WriteLine("Total count is: " + count);
        }
    }
}
