﻿using System;
using System.Linq;
class Program
{
    static void Main()
    {
        object[] a = { 1, 2, 3, "four", TimeSpan.FromHours(5) };
        foreach (var item in a.OfType<string>()) Console.WriteLine(item.ToUpper());
    }
}
