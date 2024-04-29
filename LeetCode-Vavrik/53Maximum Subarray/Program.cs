// See https://aka.ms/new-console-template for more information

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var result = solution.MaxSubArray(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
        Console.WriteLine($"Result: {result}");
    }
}