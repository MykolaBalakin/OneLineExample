using System;
using System.Linq;

Console.WriteLine(
    Enumerable
        .Repeat(0, 3)
        .Select(_ => int.Parse(Console.ReadLine()))
        .Max()
);