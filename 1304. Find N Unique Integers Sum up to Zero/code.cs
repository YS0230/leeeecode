public class Solution {
    public int[] SumZero(int n) {
        var ans = new int[n];
        for(int i = 1 , j = 0; i <= n/2; i++ , j+=2)
        {
            ans[j] = i;
            ans[j+1] = -1 * i;
        }
        if(n % 2 != 0) ans[n-1] = 0;
        return ans;
    }
}