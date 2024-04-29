// See https://aka.ms/new-console-template for more information

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        //var result1 = solution.CanJump(new[] { 2, 3, 1, 1, 4 });
        //var result2 = solution.CanJump(new[] { 3,2,1,0,4 });
        var result3 = solution.CanJump(new[] { 2,0,0 });
        Console.WriteLine($"Result : {result3}");
    }
}