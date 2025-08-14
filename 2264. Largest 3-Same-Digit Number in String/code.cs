public class Solution {
    public string LargestGoodInteger(string num) {
        var max = -1;

        for(int i = 0; i < num.Length -2; i++)
        {
            if(num[i] == num[i+1] && num[i] == num[i+2])
                max = max < num[i] - '0' ? num[i] - '0' : max;
        }   
        if(max > -1)
            return max.ToString() + max.ToString() + max.ToString();
        else
            return "";
    }
}