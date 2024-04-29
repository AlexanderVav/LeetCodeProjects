// See https://aka.ms/new-console-template for more information

public static class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine();
    }
}


public class Solution {
    public IList<TreeNode> GenerateTrees(int n)
    {
        return GenerateAllUniqueTrees(left: null, right: null);
    }

    private IList<TreeNode> GenerateAllUniqueTrees(TreeNode left, TreeNode right)
    {
        if (left.val == right.val)
        {
            return 
        }
    }
}