public class Solution {
    public int AreaOfMaxDiagonal(int[][] dimensions) {
        var len = 0;
        var maxArea = 0;
        for(int i = 0; i < dimensions.Length; i++)
        {
            var tmp = dimensions[i][0] * dimensions[i][0] + dimensions[i][1] * dimensions[i][1];

            if(tmp > len)
            {
                maxArea = dimensions[i][0] * dimensions[i][1];
                len = tmp;
            }
            else if(tmp == len)
            {
                maxArea = maxArea > dimensions[i][0] * dimensions[i][1] ? 
                                    maxArea : dimensions[i][0] * dimensions[i][1];
            }
        }

        return maxArea;
    }
}