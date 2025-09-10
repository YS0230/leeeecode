public class Solution {
    public int MinimumTeachings(int n, int[][] languages, int[][] friendships) {
        var userLanguages = new HashSet<int>[languages.Length+1];
        for(int i = 0; i < languages.Length; i++)
        {
            userLanguages[i+1] = new HashSet<int>(languages[i]);
        }

        var needHelpUser = new HashSet<int>();
        foreach(var f in friendships)
        {
            var f1 = f[0]; var f2 = f[1];
            if(!userLanguages[f1].Intersect(userLanguages[f2]).Any())
            {
                needHelpUser.Add(f1);
                needHelpUser.Add(f2);
            }
        }
        if(!needHelpUser.Any()) return 0;
        var ans = int.MaxValue;
        for(int lang = 1; lang <= n; lang++)
        {
            var knowCount  = 0;
            foreach(var user in needHelpUser)
            {
                if(userLanguages[user].Contains(lang))
                    knowCount ++;
            }

            ans = Math.Min(ans,needHelpUser.Count - knowCount);
        }
        return ans;
    }
}