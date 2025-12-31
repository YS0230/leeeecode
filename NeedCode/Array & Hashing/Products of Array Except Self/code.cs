public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var len = nums.Length;
        var ans = new int[len];
        Array.Fill(ans,1);
        var cur = 1;
        for(int i = 0; i < len; i++)
        {
            ans[i] = ans[i] * cur;
            cur = cur * nums[i];
        }
        cur = 1;
        for(int i = len - 1; i >= 0; i--)
        {
            ans[i] = ans[i] * cur;
            cur = cur * nums[i];
        }
        return ans;
    }
}