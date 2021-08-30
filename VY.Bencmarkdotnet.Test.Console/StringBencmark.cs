using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY.Bencmarkdotnet.Test
{
    [SimpleJob(BenchmarkDotNet.Jobs.RuntimeMoniker.Net50,id:"StringID")]
    [MinColumn,MaxColumn,MeanColumn,MedianColumn]
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class StringBencmark
    {
        int counter = 1000;

        [Benchmark(Baseline = true)]
        public void NormalStringProcess()
        {
            string a = "";

            for (int i = 0; i < counter; i++)
            {
                a += i.ToString();
            }
        }

        [Benchmark]
        public void BuilderStringProcess()
        {
            StringBuilder stringBuilder = new StringBuilder(counter);

            for (int i = 0; i < counter; i++)
            {
                stringBuilder.Append(i.ToString());
            }
        }
    }
}
