public class Solution {
    public bool IsPowerOfTwo(int n) {
        if(n < 1) return false;
        if(n < 3) return true;

        if(n % 2 != 0) return false;

        return IsPowerOfTwo(n / 2);
       
    }
    public bool IsPowerOfTwo2(int n) {
        return n > 0 && (n & (n - 1)) == 0;
    }
}