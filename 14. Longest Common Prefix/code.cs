public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var minLen = int.MaxValue;
        foreach(var str in strs)
        {
            minLen = Math.Min(minLen, str.Length);
        }

        for(int i = 0; i < minLen; i++)
        {
            for(int j = 0; j < strs.Length - 1; j++)
            {
                if(strs[j][i] != strs[j+1][i])
                {
                    return strs[0].Substring(0, i);
                }
            }
        }
        return strs[0].Substring(0, minLen);
        
    }
}