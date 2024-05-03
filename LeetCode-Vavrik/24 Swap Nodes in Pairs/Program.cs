// See https://aka.ms/new-console-template for more information

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var result = solution.SwapPairs(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4)))));
    }
}