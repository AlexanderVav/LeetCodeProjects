public class Solution {
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        if (head.next == null)
            return head;
        var listLeftAndRight = FindRightAndLeft(head, left, right);
        var newHead = SetLeftAndRight(head, listLeftAndRight);
        return newHead;
    }

    private ListNode SetLeftAndRight(ListNode head, List<ListNode> listLeftAndRight)
    {
        //TODO mit Schleife nach hinten also auch die darauffolgenden Elemente richtig dranhängen
        ListNode newHead = null;
        ListNode current = head;
        while (current.next != null)
        {
            if (newHead == null)
            {
                newHead = current;
            }

            if (current.next.val == listLeftAndRight.First().val)
            {
                ListNode temp = null;
                if (current.next.next != null) 
                    temp = current.next.next;
                var newMiddle = new ListNode(listLeftAndRight.Last().val);
                newMiddle.next = temp;
                current.next = newMiddle;
            }
            else if (current.next.val == listLeftAndRight.Last().val)
            {
                ListNode temp = null;
                if (current.next.next != null) 
                    temp = current.next.next;
                var newMiddle = new ListNode(listLeftAndRight.First().val);
                newMiddle.next = temp;
                current.next = newMiddle;
            }

            current = current.next;
        }

        return newHead;
        
    }

    private List<ListNode> FindRightAndLeft(ListNode head, int left, int right)
    {
        var current = head;
        var result = new List<ListNode>(2);
        while (current != null)
        {
            if (current != null)
            {
                if (current.val == left && result.Count == 0) 
                    result.Add(current);
                if (current.val == right && result.Count == 1) 
                    result.Add(current);
            }
            
            current = current.next;
        }

        return result;
    }
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    } 
}