public class Solution {
    public int LongestPalindrome(string s) {
        var map = new int['z'-'A' + 1];
        foreach(var item in s)
        {
            map[item-'A']++;
        }
        var odd = 0;
        var res = 0;
        foreach(var item in map)
        {
            int half = item / 2;
            int mod = item % 2;
            if(half > 0) res += half * 2;
            if(mod == 1) odd = 1;
        }

        return res + odd;
    }
}