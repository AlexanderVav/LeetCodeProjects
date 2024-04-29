// See https://aka.ms/new-console-template for more information

using System.Collections;

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var array = new int[][] { [2,3],[5,5],[2,2],[3,4],[3,4]};
        var result = solution.Merge(array);
        Console.WriteLine();
    }
}