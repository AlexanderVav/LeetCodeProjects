// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var result = solution.ThreeSum(new[] { -1, 0, 1, 2, -1, -4 });
        Console.WriteLine();
    }
}