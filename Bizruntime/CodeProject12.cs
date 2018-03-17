using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAnd_Await
{
    /// <summary>
    /// Class Code Project12
    /// </summary>
    class CodeProject12
    {
        /// Main method 
        static void Main(string[] args)
        {
         J :   Console.WriteLine("<<<<Please Enter two Value >>>>");///User enter to Value
            Console.WriteLine();
            int i;
            Console.Write("Enter First Vaule  :  ");
            if (int.TryParse(Console.ReadLine(), out i)) { }
            int j;
            Console.WriteLine();
            Console.Write("Enter Second Value :  ");
            j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Call(i,j);
            Console.WriteLine("You Want To Perform More Calculation then Press 1 otherwise Press AnyKey");
            int k = Convert.ToInt16(Console.ReadLine());
            if( k == 1)
            {
                goto J;
            }
            Console.ReadKey();


        }
        /// <summary>
        /// Method Print of Class Code Project12
        /// </summary>
        public async static void Print()
        {
            Console.Write("Loding");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);//thread Sleep for 100 ms
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Method Call having two parameter 
        /// </summary>
        /// <param name="i">parameter value</param>
        /// <param name="j">Parameter Value</param>
        public static async void Call(int i,int j)
        {
            ///taking array of Task and assigning four Task
            Task<int>[] task = new Task<int>[4];
            task[0] = Add(i, j);///first task
            task[1] = Sub(i, j);///second task
            task[2] = Mul(i, j);///third task
            task[3] = Div(i, j);///fourth task
            int[] a= await Task.WhenAll(task[0], task[1], task[2], task[3]);///WhenAll Manage all task
            Print();///calling Print method 
            Console.WriteLine("Addition         :  " + a[0]); ///Print Addition of Value
            Console.WriteLine("Substraction     :  " + a[1]); ///Print Addition of Value
            Console.WriteLine("Multiplication   :  " + a[2]); ///Print Multiple of Value
            Console.WriteLine("Division         :  " + a[3]);///Print Division of Value
        }
        /// <summary>
        /// Addition method 
        /// </summary>
        /// <param name="i">FirstValue Enter By User </param>
        /// <param name="j">SecondValue Enter By User</param>
        /// <returns></returns>
        static async Task<int>  Add(int i, int j)
        {
            var c = i + j;
            Console.WriteLine("<<<Hold A Moment We Are Processing Your Result>>>");
            Thread.Sleep(2000);
            return c;
        }
        /// <summary>
        /// Substraction method
        /// </summary>
        /// <param name="i">FirstValue Enter By User</param>
        /// <param name="j">Second Value Enter By User</param>
        /// <returns></returns>
        static async Task<int> Sub(int i, int j)
        {
            var c = i - j;
            await Div(i, j);
            Thread.Sleep(1500);
            return c;
        }
        /// <summary>
        /// Multiplication Method
        /// </summary>
        /// <param name="i">FirstValue</param>
        /// <param name="j">Second Value</param>
        /// <returns></returns>
        static async Task<int> Mul(int i, int j)
        {
            var c = i * j;
            Thread.Sleep(5000);
            return c;
        }
        /// <summary>
        /// Division Method
        /// </summary>
        /// <param name="i">FirstValue</param>
        /// <param name="j">Second Value</param>
        /// <returns></returns>
        static async Task<int> Div(int i ,int j)
        {
            var d = i / j;
            Thread.Sleep(700);
            return d;
        }
    }
}
