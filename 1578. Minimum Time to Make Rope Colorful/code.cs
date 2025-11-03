public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        var cost = 0;
        for(int i = 0; i < colors.Length - 1; i++)
        {
            if(colors[i] == colors[i + 1])
            {   
                if(neededTime[i] <= neededTime[i + 1])
                {
                    cost += neededTime[i];
                }
                else
                {
                    cost += neededTime[i + 1];
                    neededTime[i + 1] = neededTime[i];
                }
            }
        }
        return cost;
    }
}