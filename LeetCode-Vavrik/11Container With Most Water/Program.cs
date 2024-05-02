// See https://aka.ms/new-console-template for more information

namespace _11Container_With_Most_Water;

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var result = solution.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
        Console.WriteLine($"result : {result}");
    }
}