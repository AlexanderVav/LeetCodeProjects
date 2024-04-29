// See https://aka.ms/new-console-template for more information

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var firstData = new List<int>() { 10, 1, 2, 7, 6, 1, 5 };
        var firstResult = solution.CombinationSum2(firstData.ToArray(), 8);
        Console.WriteLine();
    }
}