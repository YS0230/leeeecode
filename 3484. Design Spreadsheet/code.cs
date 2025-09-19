public class Spreadsheet {
    private readonly int[,] grid;
    public Spreadsheet(int rows) {
        grid = new int [rows, 26];
    }
    public (int row ,int col) ParseCell(string cell)
    {
        var row = int.Parse(cell.Substring(1));
        var col = cell[0] - 'A';
        return (row - 1, col);
    }
    
    public void SetCell(string cell, int value) {
        var (row, col) = ParseCell(cell);
        grid[row, col] = value;
    }
    
    public void ResetCell(string cell) {
        SetCell(cell, 0);
    }
    
    public int GetValue(string formula) {
        if(formula[0] == '=')
            formula = formula.Substring(1);
        
        var parts = formula.Split('+');
        var sum = 0;
        foreach(var part in parts)
        {
            if(char.IsLetter(part[0]))
            {
                var (row, col) = ParseCell(part);
                sum += grid[row, col];
            }
            else
            {
                sum += int.Parse(part);
            }
        }
        return sum;

    }
}

/**
 * Your Spreadsheet object will be instantiated and called as such:
 * Spreadsheet obj = new Spreadsheet(rows);
 * obj.SetCell(cell,value);
 * obj.ResetCell(cell);
 * int param_3 = obj.GetValue(formula);
 */