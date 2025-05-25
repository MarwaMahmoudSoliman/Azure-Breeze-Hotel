```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4751/23H2/2023Update/SunValley3)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                   | Mean     | Error    | StdDev   | Median   |
|------------------------- |---------:|---------:|---------:|---------:|
| GetReservationByIdEF     | 389.6 μs | 12.88 μs | 36.96 μs | 384.3 μs |
| GetReservationByIdDapper | 126.1 μs |  5.67 μs | 16.26 μs | 120.2 μs |
