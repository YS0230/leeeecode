public class Solution {
    const int MOD = 1000000007;
    public int PeopleAwareOfSecret(int n, int delay, int forget) {
        var dp = new long[n+1];
        dp[1] = 1;
        long share = 0;
        for(int i = 2; i <= n; i++)
        {
            if(i - forget > 0)
            {
                share = (share - dp[i - forget] + MOD) % MOD;
            }

            if(i - delay > 0)
            {
                share = (share + dp[i - delay]) % MOD;
            }
            
            dp[i] = share;
        }
        int start = Math.Max(0 ,n - forget + 1);        
        long ans = 0;
        for(int i = start; i <= n; i++)
        {
             ans = (ans + dp[i]) % MOD;
        }
        
        return (int)ans;
    }
}