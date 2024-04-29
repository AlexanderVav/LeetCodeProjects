// See https://aka.ms/new-console-template for more information

using System.Resources;

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var result = solution.GenerateMatrix(3);
    }
}