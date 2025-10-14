public class Solution {
    public bool HasIncreasingSubarrays(IList<int> nums, int k) {
        int n = nums.Count;

        bool IsIncreasing(int start)
        {
            for(int i = start; i < start + k - 1; i++)
            {
                if(nums[i] >= nums[i+1]) return false;
            }
            return true;
        }

        for(int i = 0; i <= n - (2 * k); i++)
        {
            if(IsIncreasing(i) && IsIncreasing(i+k)) return true;
        }
        return false;
    }
}

public class Solution {
    public bool HasIncreasingSubarrays(IList<int> nums, int k) {
        var len = nums.Count;
        for(int i = 0; i < len; i++)
        {
            if(i + (2 * k) > len) break;
            var find1 = 1;
            for(int j = i; j < i + k - 1; j++)
            {
                if(nums[j] >= nums[j+1])
                {
                    find1 = 0;
                    break;
                }
            }
            if(find1 == 1)
            {
                var find2 = 1;
                for(int j = i + k; j < i + (2 * k) - 1; j++)
                {
                    if(nums[j] >= nums[j+1])
                    {
                        find2 = 0;
                        break;
                    }
                }
                if(find2 == 1) return true;
            }
        }

        return false;
    }
}