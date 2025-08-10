public class Solution {
    public bool ReorderedPowerOf2(int n) {
        var nFreq = new int[10];
        nFreq = GetFreq(n);
        for(int i = 0; i < 32; i++)
        {
            var powerOf2Freq = GetFreq(1 << i);
            if(ArrayEqueal(nFreq, powerOf2Freq))
                return true;
        }
        return false;
    }
    public int[] GetFreq(int n)
    {
        var res = new int[10];
        while(n > 0)
        {
            res[n % 10]++;
            n = n / 10;
        }
        return res;
    }

    public bool ArrayEqueal(int[] a, int[] b)
    {
        for(int i = 0; i < a.Length; i++)
        {
            if(a[i] != b[i])
                return false;
        }
        return true;
    }
}