class Solution:
    def generate(self, numRows: int) -> List[List[int]]:
        if numRows == 1:
            return [[1]]
        if numRows == 2:
            return [[1],[1,1]]
        ans = [[1],[1,1]]

        for i in range(2,numRows):
            tmp = []
            tmp.append(1)
            for j in range(i-1):
                tmp.append(ans[i - 1][j] + ans[i-1][j + 1])
            tmp.append(1)
            ans.append(tmp)
        return ans
    def generate2(self, numRows: int) -> List[List[int]]:
        res = [[1]]
        for i in range(2,numRows + 1):
            res.append([1] + [res[-1][j] + res[-1][j] for j in range(i-2)] + [1])
        return res