class Solution(object):
    def minCost(self, basket1, basket2):
        """
        :type basket1: List[int]
        :type basket2: List[int]
        :rtype: int
        """
        c1 = Counter(basket1)
        c2 = Counter(basket2)
        total = c1 + c2

        for count in total.values():
            if count % 2 != 0:
                return -1

        extra = []
        for key in total:
            d = c1[key] - c2[key]
            if d != 0:
                extra.append(key * abs(d) // 2)

        extra.sort()
        res = 0
        minValue = min(total)

        for i in range(len(extra)//2):
            res += min(extra[i],minValue * 2)

        return res