```

BenchmarkDotNet v0.13.7, Windows 10 (10.0.19045.3208/22H2/2022Update)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.202
  [Host]     : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.15 (6.0.1523.11507), X64 RyuJIT AVX2


```
|       Method |     Mean |    Error |   StdDev | Rank |   Gen0 | Allocated |
|------------- |---------:|---------:|---------:|-----:|-------:|----------:|
|   UseIntList | 18.19 ns | 0.387 ns | 0.362 ns |    1 | 0.0153 |      96 B |
| UseListBooks | 31.24 ns | 0.651 ns | 0.724 ns |    2 | 0.0293 |     184 B |
