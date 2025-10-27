public class Solution {
    public int MaxSubArray(int[] nums) {
        var curMax = nums[0];
        var max = nums[0];
        for(int i = 1; i < nums.Length; i++)
        {
            curMax = Math.Max(curMax + nums[i], nums[i]);
            max = Math.Max(max, curMax);
        }
        return max;
    }
}