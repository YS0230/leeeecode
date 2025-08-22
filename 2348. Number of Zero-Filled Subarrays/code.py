class Solution:
    def zeroFilledSubarray(self, nums: List[int]) -> int:
        ans = 0
        cnt = 0
        for num in nums:
            if num == 0:
                cnt += 1
                ans += cnt
            else:
                cnt = 0
        return ans