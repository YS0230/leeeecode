public class Solution {
    public int TriangularSum(int[] nums) {
        int len = nums.Length;

        if(len == 1) return nums[0];

        for(int i = len; i > 1; i--)
        {
            for(int j = 0; j < i - 1; j++)
            {
                nums[j] = (nums[j] + nums[j+1]) % 10;
            }
        }

        return nums[0];
    }
}