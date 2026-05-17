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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var quotient = 0;
        ListNode dummy = new ListNode(0);
        var cur = dummy;
        // 89 
        //  9
        // 98
        while (l1 != null || l2 != null || quotient != 0)
        {
            var l1val = l1 == null ? 0 : l1.val;
            var l2val = l2 == null ? 0 : l2.val;

            var sum = l1val + l2val + quotient;
            var remainder = sum % 10;
            quotient  = sum / 10;

            cur.next = new ListNode(remainder);

            l1 = (l1 != null) ? l1.next: null;
            l2 = (l2 != null) ? l2.next: null;
            cur = cur.next;
        }

        return dummy.next;
    }
}
