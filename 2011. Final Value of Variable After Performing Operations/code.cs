public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        var res = 0;
        foreach(var item in operations)
        {
            res += item[1] == '+' ? 1 : -1;
        }

        return res;
    }
}