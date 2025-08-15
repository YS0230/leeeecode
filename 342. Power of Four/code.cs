public class Solution {
    public bool IsPowerOfFour(int n) {
        if(n>1)
            while(n % 4 == 0) n /= 4;
        return n == 1;
    }
    public bool IsPowerOfFour1(int n) {        
        return n > 0 && (n & (n-1)) == 0 && (n & 0x55555555) != 0;
    }
}