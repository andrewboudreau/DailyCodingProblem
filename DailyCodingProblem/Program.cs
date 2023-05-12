using DailyCodingProblem;

using FluentAssertions;

Console.WriteLine("Chapter 1");
Console.WriteLine("Problem 1.1");

new[] { 1, 2, 3, 4, 5 }.ProductExceptSelf().Should().ContainInConsecutiveOrder(120, 60, 40, 30, 24);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Test Passed 1.1.1");

new[] { 3, 2, 1 }.ProductExceptSelf().Should().ContainInConsecutiveOrder(2, 3, 6);
Console.WriteLine("Test Passed 1.1.2");

new[] { 3, 7, 5, 6, 9 }.SmallestSortWindow().Should().Be((1, 3));
Console.WriteLine("Test Passed 1.2.1");

Console.ResetColor();