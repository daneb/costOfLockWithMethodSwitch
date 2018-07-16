using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostOfMethodSwitching
{
    public class Testing
    {
        private static Object thisLock = new Object();

        public static string Concat()
        {
            lock (thisLock)
            {

                string a = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8);
                string b = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8);

                //Console.WriteLine($"a: {a}");
                //Console.WriteLine($"b: {b}");

                 return a + b;
                //Console.WriteLine(result);
            }
        }
    }
}
