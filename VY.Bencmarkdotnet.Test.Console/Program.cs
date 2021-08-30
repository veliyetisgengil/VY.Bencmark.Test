using BenchmarkDotNet.Running;
using System;

namespace VY.Bencmarkdotnet.Test
{
    class Program
    {
        static void Main(string[] args)
        {

            BenchmarkRunner.Run<StringBencmark>();


            Console.ReadLine();
        }
    }
}