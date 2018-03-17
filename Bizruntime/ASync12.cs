using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAnd_Await
{
    class ASync12
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.ReadKey();
        }
        public static async void Method1()
        {
            await Task.Run(() => {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Thread 1");

                }
            });
        }
        public static void Method2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread  2");
            }
        }

    }
}
