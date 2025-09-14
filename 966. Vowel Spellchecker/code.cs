public class Solution {
    public string[] Spellchecker(string[] wordlist, string[] queries) {
        var ans = new string[queries.Length];
        var exactWord = new HashSet<string>(wordlist);
        var caseInsensitive_dict = new Dictionary<string,string>();
        var vowelError_dict = new Dictionary<string,string>();

        foreach(var word in wordlist)
        {
            var lower = word.ToLower();
            var devowel = DeVowel(lower);

            if(caseInsensitive_dict.ContainsKey(lower) == false)
                caseInsensitive_dict[lower] = word;
            if(vowelError_dict.ContainsKey(devowel) == false)
                vowelError_dict[devowel] = word;            
        }
        var idx = 0;
        foreach(var qryWord in queries)
        {
            if(exactWord.Contains(qryWord))
                ans[idx++] = qryWord;
            else if(caseInsensitive_dict.ContainsKey(qryWord.ToLower()))
                ans[idx++] = caseInsensitive_dict[qryWord.ToLower()];
            else if(vowelError_dict.ContainsKey(DeVowel(qryWord.ToLower())))
                ans[idx++] = vowelError_dict[DeVowel(qryWord.ToLower())];
            else
                ans[idx++] = "";
        }

        return ans;
    }
    public string DeVowel(string word)
    {
        var arr = word.ToCharArray();

        for(int i = 0; i < arr.Length; i++)
        {
            if("aeiou".Contains(arr[i]))
            {
                arr[i] = '*';
            }
        }
        return new string(arr);
    }
}