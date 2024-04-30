// See https://aka.ms/new-console-template for more information

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var result = solution.RemoveDuplicates(new[] { 1, 1, 2 });
    }
}

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var list = new List<int>();
        var result = new HashSet<int>();
        foreach (var current in list)
        {
            result.Add(current);
        }

        return result.Count;
    }
} 