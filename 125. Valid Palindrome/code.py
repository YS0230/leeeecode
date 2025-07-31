class Solution:
    def isPalindrome(self, s: str) -> bool:
        filtered = [c.lower() for c in s if c.isalnum()]
        return filtered == filtered[::-1]
    
    def isPalindrome2(self, s: str) -> bool:
        tmp = ""
        for c in s:
            if c.isalnum():
                tmp += c.lower()
        return tmp == tmp[::-1]
    def isPalindrome3(self, s: str) -> bool:
        left, right = 0, len(s) - 1
        while left < right:
            while left < right and not s[left].isalnum():
                left += 1
            while left < right and not s[right].isalnum():
                right -= 1
            if s[left].lower() != s[right].lower():
                return False
            left += 1
            right -= 1
        return True