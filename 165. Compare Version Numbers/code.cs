public class Solution {
    public int CompareVersion(string version1, string version2) {
        var v1 = version1.Split('.');
        var v2 = version2.Split('.');
        var len = Math.Min(v1.Length, v2.Length);
        for(int i = 0; i < len; i++)
        {
            var ve1 = GetVal(v1[i]);
            var ve2 = GetVal(v2[i]);
            if(ve1 == ve2) continue;

            return ve1 < ve2 ? -1 : 1;
        }
        if(v1.Length > v2.Length)
        {
            for(int i = len; i < v1.Length; i++)
            {
                if(GetVal(v1[i]) > 0) return 1;
            }            
        }
        else if (v1.Length < v2.Length)
        {
            for(int i = len; i < v2.Length; i++)
            {
                if(GetVal(v2[i]) > 0) return -1;
            }  
        }
        return 0;
    }
    public int GetVal(string str)
    {
        var sum = 0;
        var n = 1;
        for(int i = str.Length - 1; i > -1; i--)
        {
            sum += (str[i] - '0') * n;
            n = n * 10;
        }
        return sum;
    }
}