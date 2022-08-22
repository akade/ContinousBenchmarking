using BenchmarkDotNet.Attributes;

namespace Benchmarks;

[JsonExporterAttribute.Full]
[JsonExporterAttribute.FullCompressed]
public class SimpleBenchmarks
{
    [Benchmark]
    public void Wait50()
    {
        Thread.Sleep(80);
    }

    [Benchmark]
    public void Wait200()
    {
        Thread.Sleep(250);
    }
}