using System.Runtime.InteropServices;
using BenchmarkDotNet.Running;
using Benchmarks;

var summary = BenchmarkRunner.Run(typeof(Program).Assembly);

var benchClass = new ClassVsEnum();
Console.WriteLine($"Struct size: {Marshal.SizeOf(benchClass.StructTest())}"); 