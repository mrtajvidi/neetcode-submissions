/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        // have two pointers slow, and fast = slow + n
        // traverse until fast != null
        // 
        // when fast == null
            // remove slow
        // [1,2,3,4]
        //  s
        //      f
        // n = 2
        var dummy = new ListNode(0, head);
        var slow = dummy;

        var fast = head;
        for (int i = 1; i <= n; i++)
        {
            fast = fast.next;
        }

        while (fast != null)
        {
            slow = slow.next;
            fast = fast.next;
        }

        slow.next = slow.next.next;
        return dummy.next;
    }
}
