using System;
using System.Linq;

Console.WriteLine(
    Enumerable
        .Repeat(0, 3)
        .Select(_ => Console.ReadLine())
        .Select(int.Parse)
        .Max()
);