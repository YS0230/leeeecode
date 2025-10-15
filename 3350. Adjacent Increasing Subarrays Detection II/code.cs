public class Solution {
    public int MaxIncreasingSubarrays(IList<int> nums) {
        var len = nums.Count;
        if(len < 2) return 0;
        if(len <= 3) return 1;
        var cnt = 1;
        var preCnt = 0;
        var ans = 0;
        for(int i = 0; i < len - 1; i++)
        {
            if(nums[i] < nums[i+1])
                cnt++;
            else
            {
                preCnt = cnt;
                cnt = 1;
            }
            ans = Math.Max(ans,Math.Min(cnt,preCnt));
            ans = Math.Max(cnt /2,ans);
        }
        return ans;
    }

}