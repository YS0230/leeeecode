public class Solution {
    public int FindSmallestInteger(int[] nums, int value) {
        var map = new int[value]; 

        foreach(int item in nums)
        {
            map[((item % value) + value) % value]++;
        }
        var ans = 0;
        while(map[ans % value] > 0)
        {
            map[ans % value]--;
            ans++;
        }
        return ans;
    }
}