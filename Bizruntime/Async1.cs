using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAnd_Await
{
    /// <summary>
    /// Class Async1 
    /// </summary>
    class Async1
    {
        static void Main(string[] args)///entry point
        {
            Task<int> task = FileHand();///Assigning one method to Task
            Console.WriteLine("please wait while we Serve your request!");
            string line = Console.ReadLine();
            Console.WriteLine("You entered (asynchronous logic): " + line);

            // Wait for the HandleFile task to complete.
            // ... Display its results.
            task.Wait();///Waiting until Return value come 
            var x = task.Result;///saving return value of Result method
            Console.WriteLine("Count: " + x);

            Console.WriteLine("[DONE]");
            Console.ReadLine();
        }
        /// <summary>
        /// async FileHand()
        /// </summary>
        /// <returns></returns>
        static async Task<int> FileHand()
        {
            string file = @"D:/FileHandling C#/Bal4.txt";///path of File
            Console.WriteLine("HandleFile enter");
            int count = 0;
            try
            {
                StreamReader reader = new StreamReader(file);
                string v = await reader.ReadToEndAsync();///ReadToAsync method is Stream Reader converts All contains into string

                count += v.Length;///Length is a Properties of string which return Total length of string  
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("HandleFile exit");
            return count;///retuning count value 
        }
    }

}
