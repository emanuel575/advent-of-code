// See https://aka.ms/new-console-template for more information
using AdventOfCode;

Console.WriteLine("Hello, World!");
var adventSolutions = new List<AdventSolution>();

adventSolutions.Add(new Day1Solution());

foreach(var adventSolution in adventSolutions)
{
    adventSolution.RunAdventSolution();
}