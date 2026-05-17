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
    public ListNode ReverseList(ListNode head) {
        // 0 -> 1 -> 2 -> 3 -> null
        //             1 ->  0 -> null
        ListNode curr = head;
        ListNode prev = null;
        // head:       0,    1,  2, 
        // head.next:  1, null,  0,    
        // temp:    null,    1,  2,
        // next:    null,    0,  1,  

        while (curr != null)
        {           
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        return prev;
    }
}
