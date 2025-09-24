public class Solution {
    public string FractionToDecimal(int numerator, int denominator) {
        if(numerator == 0 || denominator == 0) return "0";

        var sb = new StringBuilder();

        if((numerator < 0) ^ (denominator < 0)) sb.Append("-");

        // 轉成 long 避免溢位
        long dividend = Math.Abs((long)numerator);
        long divisor = Math.Abs((long)denominator);


        sb.Append(dividend / divisor);

        var remider = dividend % divisor;
        if(remider == 0) return sb.ToString();
        
        sb.Append(".");
        var dict = new Dictionary<string,int>();
        while(remider != 0)
        {
            if(dict.ContainsKey(remider.ToString()))
            {
                sb.Insert(dict[remider.ToString()],"(");
                sb.Append(")");
                return sb.ToString();
            }

            dict[remider.ToString()] = sb.Length;
            remider *= 10;
            sb.Append(remider / divisor);
            remider %= divisor;
        }
        return sb.ToString();
    }
}