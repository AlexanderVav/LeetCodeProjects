// See https://aka.ms/new-console-template for more information

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var data = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var result = solution.RemoveNthFromEnd(data, 2);
    }
}


public class Solution
{

    private int currentIndex = 0;
    
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var fakeHead = new ListNode(-1, head);
        return SearchNthFromEndAndRemove(fakeHead, n, null).next;
    }

    private ListNode SearchNthFromEndAndRemove(ListNode current, int searchedIndex, ListNode prev)
    {
        if (current == null)
        {
            return current;
        }
        
        current.next = SearchNthFromEndAndRemove(current.next, searchedIndex, current);
        currentIndex++;
        
        if (prev != null)
        {
            if (currentIndex == searchedIndex)
            {
                return current.next;
            }
        }
        
        return current;

    }
}