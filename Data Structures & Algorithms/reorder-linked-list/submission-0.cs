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
    public void ReorderList(ListNode head) {
        
        // [0, n-1, 1, n-2, 2, n-3, ...]
        // Reverse the linked list --> O(n)
        // merge two lists together --> O(n)
        // until median of the list 

        // [0, 1, 2, 3, ..., n -1]
        // [n-1, n-2, n-3, ..., 1, 0]

        // [2,4,6,8]
        // [8,6,4,2]

        // [2,4,6,8,10]
        // [10,8,6,4,2]
        // [2,10,4,8,6]

        ListNode slow = head;
        ListNode fast = head.next;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode second = slow.next;
        ListNode prev = slow.next = null;
        while (second != null) {
            ListNode tmp = second.next;
            second.next = prev;
            prev = second;
            second = tmp;
        }

        ListNode first = head;
        second = prev;
        while (second != null) {
            ListNode tmp1 = first.next;
            ListNode tmp2 = second.next;
            first.next = second;
            second.next = tmp1;
            first = tmp1;
            second = tmp2;
        }
                
    }

    
}
