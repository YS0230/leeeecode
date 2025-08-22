public class Solution {
    public long ZeroFilledSubarray(int[] nums) {
        long ans = 0;
        long count = 0;

        foreach(var num in nums)
        {
            if(num == 0)
            {
                count++;
                ans+=count;
            }
            else
            {
                count = 0;
            }
        }

        return ans;
    }
}