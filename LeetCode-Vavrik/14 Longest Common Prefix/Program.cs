// See https://aka.ms/new-console-template for more information

using System.Collections.Immutable;

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var result = solution.LongestCommonPrefix(new[] { "aa", "aa" });
        //var result = solution.LongestCommonPrefix(new[] { "dog","racecar","car" });
        
    }
}