public class Solution {
    public int NextBeautifulNumber(int n) {
        var num = n + 1;
        while(true)
        {
            if(IsBalanced(num))
                return num;
            num++;
        }
        return num;
    }
    public bool IsBalanced(int num)
    {
        var map = new int[10];
        while(num != 0)
        {
            map[num % 10]++;
            num /= 10;
        }
        for(int i = 0; i < 10; i++)
        {
            if(map[i] > 0 && map[i] != i)
                return false;
        }
        return true;
    }
}