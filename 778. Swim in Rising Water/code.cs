public class Solution {
    public int SwimInWater(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        int time = grid[m-1][n-1];
        int[,] visted = new int[m,n];
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
                visted[i,j] = -1;
        }
        while(true)
        {
            DFS(grid, visted, 0, 0, time);
            if(visted[m-1,n-1] == time)
                return time;
            time++;
        }
        return time;
    }

    public void DFS(int[][] grid, int[,] visted, int x, int y, int time)
    {
        if(x < 0 || y < 0 || x >= grid.Length || y >= grid.Length || visted[x,y] == time)
            return;
        
        if(grid[x][y] <= time)
        {
            visted[x,y] = time;
            DFS(grid, visted, x + 1, y, time);
            DFS(grid, visted, x - 1, y, time);
            DFS(grid, visted, x, y + 1, time);
            DFS(grid, visted, x, y - 1, time);
        }
        
    }
}