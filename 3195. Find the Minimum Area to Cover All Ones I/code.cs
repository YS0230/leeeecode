public class Solution {
    public int MinimumArea(int[][] grid) {
        var xmax = -1;
        var xmin = grid.Length + 1;
        var ymax = -1;
        var ymin = grid[0].Length + 1;
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                if(grid[i][j] == 1)
                {
                    xmin = Math.Min(xmin,i);
                    ymin = Math.Min(ymin,j);
                    xmax = Math.Max(xmax,i);
                    ymax = Math.Max(ymax,j);
                }
            }
        }
        if(xmax == -1)
            return 0;
        return (xmax - xmin + 1) * (ymax - ymin + 1);
    }
}