using BenchmarkDotNet.Running;
using System;

namespace Benchmark.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Md5VsSha256>();
            Console.ReadLine();
        }

    }
}
