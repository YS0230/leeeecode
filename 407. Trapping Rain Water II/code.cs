public class Solution {
    public int TrapRainWater(int[][] heightMap) {
        var m = heightMap.Length;
        if(m < 3) return 0;
        var n = heightMap[0].Length;
        if(n < 3) return 0;

        bool[,] visted = new bool[m,n];
        PriorityQueue<Cell,int> heap = new PriorityQueue<Cell,int>();

        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(i == 0 || i == m - 1 || j == 0 || j == n - 1)
                {
                    heap.Enqueue(new Cell(i,j,heightMap[i][j]), heightMap[i][j]);
                    visted[i,j] = true;
                }
            }
        }
        int[,] dir = new int[,]{{0,1}, {0,-1}, {1,0}, {-1,0}};
        var trapWater = 0;
        while(heap.Count != 0)
        {
            var cell = heap.Dequeue(); 
            for(int i = 0; i < 4; i++)
            {
                var nx = cell.X + dir[i,0];
                var ny = cell.Y + dir[i,1];

                if(nx > 0 && nx < m && ny > 0 && ny < n && visted[nx,ny] == false)
                {
                    var nHeight = heightMap[nx][ny];
                    if(cell.Height > nHeight)
                    {
                        trapWater += cell.Height - nHeight;
                    }
                    var maxHeight = Math.Max(cell.Height, nHeight);
                    heap.Enqueue(new Cell(nx, ny, maxHeight), maxHeight);
                    visted[nx,ny] = true;
                }
            }
        }
        return trapWater;
    }

    public class Cell{
        public int X {get;}
        public int Y {get;}
        public int Height {get;}

        public Cell(int x, int y, int height)
        {
            X = x;
            Y = y;
            Height = height;
        }
    }


}