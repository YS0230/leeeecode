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
    public bool IsPalindrome(ListNode head) {
       var slow = head;
       var fast = head;
       ListNode pre = null;

       while(fast != null && fast.next != null)
       {
            fast = fast.next.next;
            
            var nextNode = slow.next;
            slow.next = pre;
            pre = slow;
            slow = nextNode;
       }
       var firstHalf = pre;
       var secondHalf = fast == null ? slow : slow.next;
       while(firstHalf != null)
       {
            if(firstHalf.val != secondHalf.val)
            {
                return false;
            }
            firstHalf = firstHalf.next;
            secondHalf = secondHalf.next;
       }

       return true;
    }
}