public class Solution {
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null || head.next == null || k == 0)
        {
            return head;
        }

        ListNode currentNewHead = head;
        for (int index = 0; index < k; index++)
        {
            ListNode lastNode = GetLastNode(currentNewHead);
            ListNode result = ChangeToCurrentNewHead(lastNode, currentNewHead);
            result.next = currentNewHead;
            currentNewHead = result;
        }
        return currentNewHead;
    }

    private ListNode ChangeToCurrentNewHead(ListNode searchedHead, ListNode oldHead)
    {
        ListNode current = oldHead;
        
        while (current.next != searchedHead)
        {
            current = current.next;
        }
        current.next = null;
        
        return searchedHead;
    }

    private ListNode GetLastNode(ListNode head)
    {
        ListNode tempNode = head;
        while (tempNode.next != null) 
        {
            tempNode = tempNode.next;
        }
        return tempNode;
    }
}