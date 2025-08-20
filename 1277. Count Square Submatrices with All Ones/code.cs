public class Solution {
    public int CountSquares(int[][] matrix) {
        var dp = new int[matrix.Length][];
        var ans = 0;
        for(int i = 0; i < matrix.Length; i++)
            dp[i] = new int[matrix[0].Length];

        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix[0].Length; j++)
            {
                if(j == 0 || i == 0)
                    dp[i][j] = matrix[i][j];
                else
                    if(matrix[i][j] == 1)
                        dp[i][j] = Math.Min(Math.Min(dp[i-1][j],dp[i-1][j-1]),dp[i][j-1]) + 1;
                ans += dp[i][j];
            }
        }

        return ans;
    }
}