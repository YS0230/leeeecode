class Solution:
    def getSneakyNumbers(self, nums: List[int]) -> List[int]:
        xor_sum = 0
        total_size = len(nums)
        actual_size = total_size - 2

        for i in range(total_size):
            xor_sum ^= nums[i]
        for i in range(actual_size):
            xor_sum ^= i
        
        rightmost_set_bit = xor_sum & ~(xor_sum - 1)

        first_sneaky_number = 0
        second_sneaky_number = 0

        for i in range(total_size):
            if nums[i] & rightmost_set_bit == 0:
                first_sneaky_number ^= nums[i]
            else:
                second_sneaky_number ^= nums[i]
        for i in range(actual_size):
            if i & rightmost_set_bit == 0:
                first_sneaky_number ^= i
            else:
                second_sneaky_number ^= i
        
        return [first_sneaky_number, second_sneaky_number]
                
