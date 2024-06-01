// See https://aka.ms/new-console-template for more information

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var result = solution.AddBinary("11", "1");
    }
}

public class Solution {
    public string AddBinary(string a, string b)
    {
        var first = byte.Parse(a);
        var second = byte.Parse(b);
        byte result = 0;
        for (int index = 0; index < a.Length; index++)
        {
            if (a[index] == 1)
            {
                
            }
        }
    }
}