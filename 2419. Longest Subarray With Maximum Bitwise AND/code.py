class Solution(object):
    def longestSubarray(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        maxValue = max(nums) 
        maxLen = 0
        curLen = 0

        for i in nums:
            if i == maxValue:
                curLen += 1
                maxLen = max(maxLen,curLen)    
            else:            
                curLen = 0

        return maxLen
        