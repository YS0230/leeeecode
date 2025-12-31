public class Solution {

    public string Encode(IList<string> strs) {
        string encoded = "";

        foreach(var str in strs)
        {
            encoded += str.Length + "#" + str;
        }
        
        return encoded;
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();

        var lastPos = 0;
        while(lastPos < s.Length)
        {
            var cur = lastPos;
            while(s[cur] != '#') cur++;
            var len = int.Parse(s.Substring(lastPos, cur - lastPos));
            var str = s.Substring(cur + 1, len);
            result.Add(str);
            lastPos = cur + len + 1;
        }

        return result;
   }
}
