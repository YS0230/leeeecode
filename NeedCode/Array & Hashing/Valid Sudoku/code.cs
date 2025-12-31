public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        for(int row = 0; row < 9; row++)
        {
            var arr = new int[10];
            for(int col = 0; col < 9; col++)
            {
                if(board[row][col] == '.') continue;
                var target = board[row][col] - '0';
                if(arr[target] == 1) return false;
                arr[target] = 1;       
            }
        }
        for(int col = 0; col < 9; col++)
        {
            var arr = new int[10];
            for(int row = 0; row < 9; row++)
            {
                if(board[row][col] == '.') continue;
                var target = board[row][col] - '0';
                if(arr[target] == 1) return false;
                arr[target] = 1;       
            }
        }
        for(int x = 0; x < 9; x += 3)
        {
            for(int y = 0; y < 9; y += 3)
            {
                var arr = new int[10];
                for(int row = x; row < x + 3; row++)
                {
                    for(int col = y; col < y + 3; col++)
                    {
                        if(board[row][col] == '.') continue;
                        var target = board[row][col] - '0';
                        if(arr[target] == 1) return false;
                        arr[target] = 1;
                    }
                }
            }    
        }
        return true;
    }
}
