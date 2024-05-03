public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }
        
        var dummy = new ListNode(-1); // dummy node to simplify edge cases
        dummy.next = head;
        var temp = dummy;
        int index = 0;
        
        while (temp.next != null && temp.next.next != null) {
            if (index % 2 == 0) {
                temp.next = SwitchNodes(temp.next, temp.next.next);
            }
            temp = temp.next;
            index++;
        }

        return dummy.next;
    }

    private ListNode SwitchNodes(ListNode temp, ListNode tempNext) {
        var old = tempNext;
        temp.next = tempNext.next;
        old.next = temp;
        return old;
    }
}