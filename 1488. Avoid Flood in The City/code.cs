public class Solution {
    public int[] AvoidFlood(int[] rains) {
        int[] ans = new int[rains.Length];
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i = 0; i < rains.Length; i++)
        {
            if(rains[i] == 0)
            {
                ans[i] = -2;
            }
            else if(!dict.ContainsKey(rains[i]) || dict[rains[i]] == -1)
            {
                dict[rains[i]] = i;
                ans[i] = -1;
            }
            else
            {
                var find = 0;
                for(int j = dict[rains[i]] + 1; j < i; j++)
                {
                    if(ans[j] == -2)
                    {
                        ans[j] = rains[i];
                        find = 1;
                        break;
                    }
                }
                if(find == 0) return [];
                dict[rains[i]] = i;            
                ans[i] = -1;
            }
        }

        for(int i = 0; i < rains.Length; i++)
        {
            if(ans[i] == -2)
                ans[i] = 1;
        }

        return ans;

    }
}