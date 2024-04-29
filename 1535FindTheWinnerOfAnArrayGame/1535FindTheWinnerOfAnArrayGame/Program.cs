// See https://aka.ms/new-console-template for more information

public static class Program
{
    public static void Main(string[] args)
    {
			//https://leetcode.com/problems/find-the-winner-of-an-array-game/
        Solution solution = new Solution();
        var firstResult = solution.GetWinner(new int[] { 1,11,22,33,44,55,66,77,88,99 }, 1000000000);
        Console.WriteLine($"Result : {firstResult}");
    }
}