public class Solution {
    public string SortVowels(string s) {
        var vowels_dict = new Dictionary<char,int>();
        var vowels = "AEIOUaeiou";
        var vowels_idx = new List<int>();
        for(int i = 0; i < s.Length; i++)
        {
            if(vowels.Contains(s[i]))
            {
                vowels_idx.Add(i);
                vowels_dict[s[i]] = vowels_dict.ContainsKey(s[i]) ? vowels_dict[s[i]] + 1: 1;                
            }
        }
        if(!vowels_idx.Any()) return s;
        var temp = s.ToCharArray();
        var idx = 0;
        foreach(var c in vowels)
        {
            if(vowels_dict.ContainsKey(c))
            {
                while(vowels_dict[c] > 0)
                {
                    temp[vowels_idx[idx++]] = c;
                    vowels_dict[c] --;
                }
            }
        }

        return new String(temp);
    }
}