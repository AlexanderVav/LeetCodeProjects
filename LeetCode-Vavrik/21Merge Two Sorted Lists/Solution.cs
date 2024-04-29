public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var allNumbers = new List<int>();
        GetAllInt(allNumbers, list1);
        GetAllInt(allNumbers, list2);
        allNumbers.Sort();
        var newHead = CreateNewNode(allNumbers);
        return newHead;
    }

    private ListNode CreateNewNode(List<int> allNumbers)
    {
        ListNode head = null;
        while (allNumbers.Count > 0)
        {
            var current = allNumbers.First();
            allNumbers.RemoveAt(0);
            if (head == null) 
                head = new ListNode(current);
            else
            {
                var last = GetLastNode(head);
                last.next = new ListNode(current);
            }
        }

        return head;
    }

    private ListNode GetLastNode(ListNode current) 
    {
        while (current.next != null)
        {
            current = current.next;
        }

        return current;
    }

    private void GetAllInt(List<int> allNumbers, ListNode current)
    {
        var headFirst = current;
        while (headFirst != null)
        {
            allNumbers.Add(headFirst.val);
            headFirst = headFirst.next;
        }
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