public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if(magazine.Length < ransomNote.Length) return false;

        var map = new int[26];
        foreach(var item in magazine)
        {
            map[item - 'a']++;
        }
        foreach(var item in ransomNote)
        {
            if(map[item-'a'] ==0)
                return false;
            else
                map[item-'a']--;
        }
        return true;
    }
}