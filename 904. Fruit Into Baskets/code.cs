public class Solution {
    public int TotalFruit(int[] fruits) {
        var maxValue  = 0;
        var basket = new Dictionary<int,int>();
        var left = 0;
        for(int right = 0; right < fruits.Length; right++)
        {
            if(basket.ContainsKey(fruits[right]))
                basket[fruits[right]]++;
            else
                basket[fruits[right]] = 1;

            while(basket.Count > 2)
            {
                basket[fruits[left]]--;
                if(basket[fruits[left]] == 0)
                    basket.Remove(fruits[left]);
                left++;
            }
            maxValue = Math.Max(maxValue,right - left + 1);
        }
        return maxValue;
    }
}