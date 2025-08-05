public class Solution {
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets) {
        int ans = fruits.Length;
        for(int i = 0; i < fruits.Length; i++)
        {
            for(int j = 0 ; j < baskets.Length; j++)
            {
                if(fruits[i] <= baskets[j])
                {
                    baskets[j] = 0;
                    ans--;
                    break;
                }
            }
        }
        return ans;
    }
}