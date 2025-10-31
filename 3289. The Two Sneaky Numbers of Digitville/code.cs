public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        Array.Sort(nums);
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] == nums[i - 1])
            {
                for(int j = i + 2; j < nums.Length; j++)
                {
                    if(nums[j] == nums[j - 1])
                        return new int[]{nums[i],nums[j]};
                }
            }
        }
        return null;
    }
}