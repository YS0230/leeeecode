public class Solution {
    public int ClimbStairs(int n) {
        if(n <= 3) return n;

        var dp = new int[n+1];
        dp[0] = 0;
        dp[1] = 1;
        dp[2] = 2;
        dp[3] = 3;
        for(int i = 4; i <= n; i++)
        {
            dp[i] = dp[i-2] + dp[i-1];
        }
        return dp[n];
    }
}