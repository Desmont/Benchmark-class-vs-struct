### Benchmark results
DefaultJob : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT


|          Method |     Mean |    Error |   StdDev |  Gen 0 | Allocated |
|---------------- |---------:|---------:|---------:|-------:|----------:|
|      StructTest | 42.66 ns | 0.063 ns | 0.056 ns |      - |         - |
|       ClassTest | 45.86 ns | 0.301 ns | 0.281 ns | 0.0033 |      56 B |
| StructBoxedTest | 53.13 ns | 0.805 ns | 0.713 ns | 0.0033 |      56 B |
|  ClassBoxedTest | 45.71 ns | 0.313 ns | 0.293 ns | 0.0033 |      56 B |


### Microsoft recommendations
Taken from: https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/choosing-between-class-and-struct

AVOID defining a struct unless the type has all of the following characteristics:
- [FAIL] It logically represents a single value, similar to primitive types (int, double, etc.).

- [FAIL] It has an instance size under 16 bytes. (16 bytes == 2 reference type pointers, RegisterMobileDeviceCommandStruct is 40 bytes)

- [PASS] It is immutable.

- [MAYBE/PASS] It will not have to be boxed frequently.