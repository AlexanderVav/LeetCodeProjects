// See https://aka.ms/new-console-template for more information

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        //var data = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var data = new ListNode(1, new ListNode(2));
        var result = solution.RotateRight(data, 1);
        Console.WriteLine();
    }
}