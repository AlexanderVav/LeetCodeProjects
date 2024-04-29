public class Solution {
    public ListNode SortList(ListNode head) {
        // Basisfall: Wenn die Liste leer oder nur ein Element hat
        if (head == null || head.next == null) {
            return head;
        }

        // Teile die Liste in zwei Hälften
        ListNode[] halves = SplitList(head);

        // Sortiere beide Hälften rekursiv
        ListNode leftSorted = SortList(halves[0]);
        ListNode rightSorted = SortList(halves[1]);

        // Füge die sortierten Hälften zusammen
        return Merge(leftSorted, rightSorted);
    }

    // Teile die Liste in zwei Hälften
    private ListNode[] SplitList(ListNode head) {
        //slow represents the new middle Node that I want. Which after this should be my new head.  
        ListNode slow = head;
        //fast is the the pointer or my check if node equals null
        ListNode fast = head;
        //prev is needed as a kind of bridge to make sure I wont have a circle and cut the pointer to the new head
        ListNode prev = null;

        //go all the way to the end and fast because it so fast travels twice as much as slow
        while (fast != null && fast.next != null) {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        //this is set to cut the pointer to my new head
        if (prev != null) {
            prev.next = null;
        }

        return new ListNode[] {head, slow};
    }

    // Füge zwei sortierte Listen zusammen
    private ListNode Merge(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode();
        ListNode current = dummy;

        while (l1 != null && l2 != null) {
            if (l1.val < l2.val) {
                current.next = l1;
                l1 = l1.next;
            } else {
                current.next = l2;
                l2 = l2.next;
            }
            current = current.next;
        }

        if (l1 != null) {
            current.next = l1;
        } else {
            current.next = l2;
        }

        return dummy.next;
    }
}