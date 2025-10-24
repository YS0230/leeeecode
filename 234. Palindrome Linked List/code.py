# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def isPalindrome(self, head: Optional[ListNode]) -> bool:
        slow = head
        fast = head
        pre = None
        while fast and fast.next :
            fast = fast.next.next

            nextNode = slow.next
            slow.next = pre
            pre = slow
            slow = nextNode
        
        firstHalf = pre
        secondHalf = slow.next if fast else slow 

        while firstHalf:
            if firstHalf.val != secondHalf.val:
                return False
            firstHalf = firstHalf.next
            secondHalf = secondHalf.next
        
        return True
        