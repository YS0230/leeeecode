public class Solution {
    public double SoupServings(int n) {
        if (n >= 5000) return 1.0;
        var len = (n + 24) / 25;
        var memory = new double[len + 1][];
        for(int i = 0; i < len + 1; i++)
        {
            memory[i] = new double[len + 1];
            for(int j = 0; j < len + 1; j++)
                memory[i][j] = -1;
        }

        return dp(len, len, memory);
    }

    public double dp(int a, int b, double[][] memory)
    {
        if(a <= 0 && b <= 0)
            return 0.5;
        if(a <= 0 && b > 0)
            return 1;
        if(a > 0 && b <= 0)
            return 0;
        if(memory[a][b] == -1)
            memory[a][b] = 0.25 * ( dp(a - 4, b, memory) + 
                                    dp(a - 3, b - 1, memory) + 
                                    dp(a - 2, b-2, memory) + 
                                    dp(a - 1, b - 3, memory));    

        return memory[a][b];
    }
}