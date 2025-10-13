public class Solution {
    public IList<string> RemoveAnagrams(string[] words) {
        var res = new List<string>();
        res.Add(words[0]);
        for(int i = 1; i < words.Length; i++)
            if(!IsAnagrams(words[i-1],words[i])) res.Add(words[i]);
        return res;

    }
    public bool IsAnagrams(string word1, string word2)
    {
        if(word1 == word2) return true;
        if(word1.Length != word2.Length) return false;

        var map = new int[26];

        foreach(var ch in word1)
            map[ch - 'a']++;
        foreach(var ch in word2)
            if(--map[ch - 'a'] < 0) return false;

        return true;
    }
}