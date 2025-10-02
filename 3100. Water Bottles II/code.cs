public class Solution {
    public int MaxBottlesDrunk(int numBottles, int numExchange) {        
        var count = numBottles;
        var empty = numBottles;

        while(empty >= numExchange)
        {
            count++;
            empty = empty - numExchange;
            empty++;
            numExchange++;
        }

        return count;
    }
}