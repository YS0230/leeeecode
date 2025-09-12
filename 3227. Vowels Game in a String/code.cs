public class Solution {
    public bool DoesAliceWin(string s) {
        for(int i = 0; i < s.Length; i++)
        {
            if("AEIOUaeiou".Contains(s[i]))
                return true;
        }
        return false;
    }
}