public class Solution {
    public int FindClosest(int x, int y, int z) {        
        return Math.Abs(z-x) == Math.Abs(z-y) ? 0 : Math.Abs(z-x) > Math.Abs(z-y) ? 2 : 1; 
    }
}