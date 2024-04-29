// See https://aka.ms/new-console-template for more information
public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var result = solution.ReverseBetween(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))), 2, 4);
        Console.WriteLine($"Result: {result}");
    }
}

//https://leetcode.com/problems/reverse-linked-list-ii/description/