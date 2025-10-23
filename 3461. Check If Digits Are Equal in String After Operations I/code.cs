public class Solution {
    public bool HasSameDigits(string s) {
       var arr = new int[s.Length];

       for(int i = 0; i < s.Length; i++)
       {
            arr[i] = s[i] - '0';
       }
       var cnt = s.Length;
       while(cnt > 2)
       {
            for(int i = 0; i < cnt - 1; i++)
            {
                arr[i] = (arr[i] + arr[i + 1]) % 10;
            }
            cnt--;
       }
        
        return arr[0] == arr[1];
    }
}