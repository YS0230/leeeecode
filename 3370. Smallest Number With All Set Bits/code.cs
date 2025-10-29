public class Solution {
    public int SmallestNumber(int n) {
        var res = 0;
        while(n > 0)
        {
            n >>= 1;
            res = (res << 1) + 1;
        }
        return res;
    }
}