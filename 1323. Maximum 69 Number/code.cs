public class Solution {
    public int Maximum69Number (int num) {
        var tmp = num.ToString().ToArray();
        for(int i = 0; i < tmp.Length; i++)
        {
            if(tmp[i] == '6')
            {
                tmp[i] = '9';
                return Convert.ToInt32(new string(tmp));
            }
        }
        return num;
    }
}