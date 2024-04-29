public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        solution.MergeTwoLists(new ListNode(1, new ListNode(2, new ListNode(3))), new ListNode(1, new ListNode(2, new ListNode(3))));
    }
}