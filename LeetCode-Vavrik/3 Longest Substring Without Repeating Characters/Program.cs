// See https://aka.ms/new-console-template for more information

namespace _3_Longest_Substring_Without_Repeating_Characters;

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var result = solution.LengthOfLongestSubstring("abcabcbb");
        Console.WriteLine($"Result: {result}");
    }
}

public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0)
            return 0;
        var listOfCount = new List<List<char>>();

        foreach (var currentChar in s)
        {
            if (listOfCount.Count == 0) 
                listOfCount.Add(new List<char>(currentChar));
            var key = ConainsKey(currentChar, listOfCount);
            if (key == -1)
                listOfCount.Add(new List<char>(currentChar));
            else
                listOfCount[key].Add(currentChar);
        }
        
        listOfCount.Sort();
        return listOfCount.Last().Count;
    }

    private int ConainsKey(char currentChar, List<List<char>> listOfCount)
    {
        for (var index = 0; index < listOfCount.Count; index++)
        {
            var currentList = listOfCount[index];
            if (currentList.Contains(currentChar))
                return index;
        }

        return -1;
    }
}