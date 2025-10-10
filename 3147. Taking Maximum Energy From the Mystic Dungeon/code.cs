public class Solution {
    public int MaximumEnergy(int[] energy, int k) {
        var maxEnergy = int.MinValue;
        for(int i =  energy.Length - 1; i > energy.Length - k - 1; i--)
        {
            var idx = i;
            var curEnergy = 0;
            while(idx > -1)
            {
                curEnergy += energy[idx];
                maxEnergy = Math.Max(maxEnergy,curEnergy);
                idx-=k;
            }
        }
        return maxEnergy;
    }
}