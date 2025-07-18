class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        lookup = {}
        for index, num in enumerate(nums):
            diff = target - num
            if diff in lookup:
                return [lookup[diff],index]
            else:
                lookup[num] = index
        return []