// See https://aka.ms/new-console-template for more information

using System.Collections.Immutable;

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var result = solution.LongestCommonPrefix(new[] { "flower", "flow", "flight" });
        //var result = solution.LongestCommonPrefix(new[] { "dog","racecar","car" });
        
    }
}

public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        var listOfData = new List<string>(strs);
        listOfData.Sort();
        var result = listOfData.First();

        for (int index = 1; index < strs.Length; index++)
        {
            var currentStrArray = listOfData[index];
            
        }
    }
}