public class Solution {
    public int MaxTotalFruits(int[][] fruits, int startPos, int k) {
        var left = new int[k + 1];
        var right = new int[k + 1];

        for(int i = 0 ; i < fruits.Length; i++)
        {
            var diff = startPos - fruits[i][0];
            var amount = fruits[i][1];
            if(diff == 0)
            {
                left[0] = right[0] = amount;
            }
            else
            {
                if(diff <= k && diff > 0)
                {
                    right[diff] = amount;
                }
                if(Math.Abs(diff) <= k && diff < 0)
                {
                    left[Math.Abs(diff)] = amount;
                }
            }
        }

        for(int i = 1 ; i <= k ; i++)
        {
            left[i] = left[i] + left[i - 1];
            right[i] = right[i] + right[i - 1];
        }

        var res = 0;
        var l_idx = 0;
        var r_idx = 0;
        var sum = 0;
        for(int i = 0 ; i <= k; i++)
        {
            l_idx = k - i;
            r_idx = k  - l_idx * 2;
            if(r_idx > 0)
            {
                sum = left[l_idx] + right[r_idx];
                if(left[l_idx] > 0 && right[r_idx] > 0)
                    sum = sum - left[0];                    
                res = Math.Max(res,sum);
            }
            else
            {
                res = Math.Max(res,left[l_idx]);
            }            
        }
        for(int i = 0 ; i <= k; i++)
        {
            r_idx = k - i;
            l_idx = k  - r_idx * 2;
            if(l_idx > 0)
            {
                sum = left[l_idx] + right[r_idx];
                if(left[l_idx] > 0 && right[r_idx] > 0)
                    sum = sum - left[0];                    
                res = Math.Max(res,sum);
            }
            else
            {
                res = Math.Max(res,right[r_idx]);
            }            
        }

        return res;

    }
}