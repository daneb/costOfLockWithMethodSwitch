using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CostOfMethodSwitching
{
    class Program
    {
        public static int ITERATION = 100000;

        static void Main(string[] args)
        {
            // var summary = BenchmarkRunner.Run<Worker>();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Worker worker = new Worker();
            sw.Stop();

            string ExecutionTimeTaken = string.Format("Minutes :{0} Seconds :{1} Mili seconds :{2}", sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.TotalMilliseconds);
            //Console.WriteLine($"Inline Execution Time -> {ExecutionTimeTaken}");
            Console.WriteLine($"Static Execution Time -> {ExecutionTimeTaken}");
        }
    }
}
