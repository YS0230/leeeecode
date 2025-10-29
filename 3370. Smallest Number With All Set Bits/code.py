class Solution:
    def smallestNumber(self, n: int) -> int:
        res = 0
        while n > 0:
            n >>= 1
            res = (res << 1) + 1
        return res