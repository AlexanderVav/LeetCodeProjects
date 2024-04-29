// See https://aka.ms/new-console-template for more information

public static class Program
{
    public static void Main(string[] args)
    {
        var data = new ListNode(4, new ListNode(2, new ListNode(1, new ListNode(3))));
        Solution solution = new Solution();
        var result = solution.SortList(data);
        Console.WriteLine();
    }
}