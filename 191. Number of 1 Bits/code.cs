public class Solution {
    public int HammingWeight(int n) {
        var res = 0;
        while(n > 0)
        {
            n = n & (n - 1);
            res++;
        }
        return res;
    }
}