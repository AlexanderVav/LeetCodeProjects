// See https://aka.ms/new-console-template for more information

public static class Program
{
    public static void Main(string[] args)
    {
        var solution = new Solution();
        var result = solution.CountAndSay(5);
        Console.WriteLine($"result: {result}");
    }
}