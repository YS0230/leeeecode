public class Solution {
    public int maxTotalFruits(int[][] fruits, int startPos, int k) {
        int n = fruits.length;
        int left = 0, right = 0;
        int maxFruits = 0;
        int currentSum = 0;

        while (right < n) {
            // 加入右側水果數量
            currentSum += fruits[right][1];

            // 當 [left, right] 區間不能在 k 步內抵達，就要縮小左邊界
            while (left <= right && !isWithinSteps(fruits, left, right, startPos, k)) {
                currentSum -= fruits[left][1];
                left++;
            }

            // 若此區間合法，更新最大水果數量
            maxFruits = Math.max(maxFruits, currentSum);
            right++;
        }

        return maxFruits;
    }

    // 檢查從 startPos 到 fruits[left...right] 區間的最小步數是否 <= k
    private boolean isWithinSteps(int[][] fruits, int left, int right, int startPos, int k) {
        int leftPos = fruits[left][0];
        int rightPos = fruits[right][0];

        // 方法一：先往左再往右（折返）
        int stepsLeftFirst = Math.abs(startPos - leftPos) + (rightPos - leftPos);

        // 方法二：先往右再往左（折返）
        int stepsRightFirst = Math.abs(startPos - rightPos) + (rightPos - leftPos);

        // 兩者只要有一個步數在 k 內就合法
        return Math.min(stepsLeftFirst, stepsRightFirst) <= k;
    }
}
