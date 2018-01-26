﻿class Program
{
    static void Main(string[] args)
    {
        var dictionary = new System.Collections.Generic.Dictionary<int, string>()
        {
            { 1, "first" }, { 2, "second" }, { 3, "third" }
        };
        foreach (var n in dictionary.Keys) System.Console.WriteLine($"{n}={dictionary[n]}");
    }
}
