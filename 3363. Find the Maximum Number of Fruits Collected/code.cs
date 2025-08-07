public class Solution {
    public int MaxCollectedFruits(int[][] fruits) {
        var player1 = 0;
        var len = fruits.Length;
        var memory = new int[len][];
        for(int i = 0; i < len; i++)
        {
            memory[i] = new int[len];
            for(int j = 0; j < len; j++)
                memory[i][j] = -1;
        }
            
        for(int i = 0; i < fruits.Length; i++)
        {
            player1 += fruits[i][i];
        }

        return player1 + dp1(0, len - 1, len, fruits, memory) + dp2(len - 1, 0, len, fruits, memory);
    }

    public int dp1(int x, int y, int len, int[][] fruits, int[][] memory)
    {
        if(memory[x][y] != -1)
            return memory[x][y];

        if(x == len - 2 && y == len - 1)
            return fruits[x][y];

        var ans = 0;

        for(int i = y - 1 ; i < y + 2; i++)
        {
            if( i < len && i > x + 1)
                ans = Math.Max(ans,fruits[x][y] + dp1(x + 1, i, len, fruits, memory));
        }
        memory[x][y] = ans;
        return ans;
    }
    public int dp2(int x, int y, int len, int[][] fruits, int[][] memory)
    {
        if(memory[x][y] != -1)
            return memory[x][y];

        if(x == len - 1 && y == len - 2)
            return fruits[x][y];

        var ans = 0;

        for(int i = x - 1; i < x + 2; i++)
        {
            if(i < len  && i > y + 1)
                ans = Math.Max(ans,fruits[x][y] + dp2(i, y + 1, len, fruits, memory));
        }

        memory[x][y] = ans;
        return ans;
    }
}