using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CostOfMethodSwitching
{
    public class Worker
    {
       
        public Worker()
        {
            Run();
        }

        public void Run()
        {
            for (int i = 0; i < 500; i++)
            {
                ThreadStart job = new ThreadStart(GenerateStrings);
                Thread thread = new Thread(job);
                thread.Start();
            }
        }

        public void GenerateStrings()
        {
            List<string> something = new List<string>();

            //for (int i = 0; i < Program.ITERATION; i++)
            //{
            //    string a = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8);
            //    string b = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 8);

            //    something.Add(a + b);
            //}

            for (int i = 0; i < Program.ITERATION; i++)
            {
               something.Add(Testing.Concat());
            }
        }
    }
}
