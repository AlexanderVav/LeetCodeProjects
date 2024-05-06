// See https://aka.ms/new-console-template for more information

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var result = solution.ClimbStairs(44);
        Console.WriteLine($"Steps needed : {result}");
    }
}

public class Solution
{
    public int ClimbStairs(int n) 
    {
        if (n <= 0)
        {
            return 0;
        }
        
        if (n == 1)
        {
            return 1;
        }
        
        if (n == 2)
        {
            return 2;
        }
        
        int first = 1;
        int second = 2;
        
        for (int i = 3; i <= n; i++)
        {
            int third = first + second;
            first = second;
            second = third;
        }
        
        return second;
    }
}
