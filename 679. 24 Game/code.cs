public class Solution {
     public bool JudgePoint24(int[] cards) {
        var list = new List<double>();
        foreach(var item in cards) list.Add(item);

        return Dfs(list);
    }

    private bool Dfs(List<double> nums) {
        if(nums.Count == 1)
        {
            return Math.Abs(24-nums[0]) < 1e-6;
        }

        for(int i = 0; i < nums.Count; i++)
        {
            for(int j = 0; j < nums.Count; j++)
            {
                if(i == j) continue;

                var next = new List<double>();
                for(int k = 0; k < nums.Count; k++)
                {
                    if(k != i && k != j)
                        next.Add(nums[k]);
                }
                var a = nums[i];
                var b = nums[j];
                for(int z = 0; z < 6; z++)
                {
                    if(z == 0) next.Add(a + b);
                    else if(z == 1) next.Add(a - b);
                    else if(z == 2) next.Add(b - a);
                    else if(z == 3) next.Add(a * b);
                    else if(z == 4 && Math.Abs(a) > 1e-6) next.Add(b / a);
                    else if(z == 5 && Math.Abs(b) > 1e-6) next.Add(a / b);
                    else continue;

                    if(Dfs(next))
                        return true;

                    next.RemoveAt(next.Count - 1); // 回溯
                }

            }
        }

        return false;
    }
}