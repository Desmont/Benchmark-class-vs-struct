using BenchmarkDotNet.Attributes;

namespace Benchmarks;

[MemoryDiagnoser]
public class ClassVsEnum
{
    public record struct RegisterMobileDeviceCommandStruct(Guid InterpreterAdb2cId, string DeviceToken, string Platform,
        string DeviceModel);

    public record RegisterMobileDeviceCommandClass(Guid InterpreterAdb2cId, string DeviceToken, string Platform,
        string DeviceModel);

    private static readonly string DeviceToken = "DeviceToken";
    private static readonly string Platform = "Platform";
    private static readonly string DeviceModel = "DeviceModel";

    [Benchmark]
    public RegisterMobileDeviceCommandStruct StructTest()
    {
        var result = new RegisterMobileDeviceCommandStruct(Guid.NewGuid(), DeviceToken, Platform, DeviceModel);
        return result;
    }

    [Benchmark]
    public RegisterMobileDeviceCommandClass ClassTest()
    {
        var result = new RegisterMobileDeviceCommandClass(Guid.NewGuid(), DeviceToken, Platform, DeviceModel);
        return result;
    }
}