public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var maxLen = 0;
        var left = 0;
        var seen = new HashSet<char>();

        for(int i = 0; i < s.Length; i++)
        {
            while(seen.Contains(s[i]))
            {
                seen.Remove(s[left++]);
            }
            seen.Add(s[i]);
            maxLen = Math.Max(maxLen, seen.Count);
        }

        return maxLen;
    }
}