public class Solution {
    public int[] FindDiagonalOrder(int[][] mat) {
        var m = mat.Length;
        var n = mat[0].Length;
        var ans = new int[m*n];
        var idx = 0;
        var row = 0;
        var col = 0;
        var direct = 1;
        for(int i = 0; i < m * n; i++)
        {
            ans[idx++] = mat[row][col];

            if(direct == 1)
            {
                if(row == 0 && col == n -1){direct = -1; row = 1;}
                else if(row == 0){direct = -1; col++;}
                else if(col == n - 1){direct = -1; row++;}
                else{row--; col++;}
            }
            else
            {
                if(row == m - 1 && col == 0){direct = 1; col = 1;}
                else if(col == 0){direct = 1; row++;}
                else if(row == m -1){direct = 1; col++;}
                else{row++; col--;}
            }
        }
        return ans;
    }
}