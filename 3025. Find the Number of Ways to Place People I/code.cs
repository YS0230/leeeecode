public class Solution {
    public int NumberOfPairs(int[][] points) {
        var len = points.Length;
        var count = 0;
        for(int i = 0; i < len; i++)
        {
            var Ax = points[i][0];
            var Ay = points[i][1];

            for(int j = 0; j < len; j++)
            {
                if(i == j) continue;
                var Bx = points[j][0];
                var By = points[j][1];

                if(Ax <= Bx && Ay >= By)
                {
                    var vaild = 1;
                    for(int k = 0; k < len; k++)
                    {
                        if(i == k || j == k) continue;
                        var Cx = points[k][0];
                        var Cy = points[k][1]; 
                        if(Ax <= Cx && Cx <= Bx && Ay >= Cy && Cy >= By)
                        {
                           vaild = 0;
                           break;
                        }
                    }
                    if(vaild == 1) count++;
                }
            }
        }
        return count;
    }
}