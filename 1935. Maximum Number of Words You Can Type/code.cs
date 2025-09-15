public class Solution {
    public int CanBeTypedWords(string text, string brokenLetters) {
        var total = 1;
        var error = 0;
        for(int i = 0; i < text.Length; i++)
        {
            if(text[i] == ' ')
            {
                total++;
                continue;
            } 
            if(brokenLetters.Contains(text[i]))
            {
                error++;
                while(i < text.Length && text[i] != ' ') i++;

                i--;
            }
        }
        return total - error;
    }
}