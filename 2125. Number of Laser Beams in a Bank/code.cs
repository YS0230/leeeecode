public class Solution {
    public int NumberOfBeams(string[] bank) {
        var beam = 0;
        var preDevice = 0;
        var curDevice = 0;
        foreach(var row in bank)
        {
            curDevice = 0;
            foreach(var col in row)
            {
                curDevice += col & 1;
            }
            if(curDevice > 0)
            {
                beam += preDevice * curDevice;
                preDevice = curDevice;
            }
        }

        return beam;
    }
}