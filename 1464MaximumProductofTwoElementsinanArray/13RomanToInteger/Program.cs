// See https://aka.ms/new-console-template for more information

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine($"Result: {solution.RomanToInt("MDCCCLXXXIV")}");
    }
}