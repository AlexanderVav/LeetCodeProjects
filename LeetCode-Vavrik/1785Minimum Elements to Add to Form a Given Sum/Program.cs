// See https://aka.ms/new-console-template for more information
public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        //Console.WriteLine($"Result : {solution.MinElements(new[] { 1, -1, 1 }, 3, -4)}");
        //Console.WriteLine($"Result : {solution.MinElements(new[] { 1,-10,9,1 }, 100, 0)}");
        Console.WriteLine($"Result : {solution.MinElements(new[] { 2,2,2,5,1,-2 }, 5, 126614243)}");
    }
}