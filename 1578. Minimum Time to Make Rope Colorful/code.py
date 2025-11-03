class Solution:
    def minCost(self, colors: str, neededTime: List[int]) -> int:
        cost = 0
        for i in range(len(colors) - 1):
            if colors[i] == colors[i + 1]:
                if neededTime[i] <= neededTime[i + 1]:
                    cost = cost + neededTime[i]
                else:
                    cost = cost + neededTime[i + 1]
                    neededTime[i + 1] = neededTime[i]
        return cost