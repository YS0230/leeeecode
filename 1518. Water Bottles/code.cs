public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        var count = 0 ;
        var full = numBottles;
        var empty = 0;
        while(full != 0)
        {
            count += full;            
            empty += full;
            full  = empty / numExchange;            
            empty = empty % numExchange;
        }

        return count;
    }
}