public class Solution {
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets) {
        var segmentTree = new int[fruits.Length * 4];
        var len = fruits.Length - 1;
        BuildSegmentTree(0, 0, len, segmentTree, baskets);

        var unplaced = 0;

        for(int i = 0 ; i < fruits.Length ; i++)
        {
            if(segmentTree[0] < fruits[i])
            {
                unplaced++;
            }       
            else
            {
                var idx = FindLeftMost(0, 0, len, fruits[i], segmentTree);
                UpdateNodeValue(0, 0, len, idx,segmentTree);
            }
        }

        return unplaced;
    }

    public void BuildSegmentTree(int node, int start, int end, int[] tree,int[] baskets)
    {
        if (start == end)
        {
            tree[node] = baskets[start];
            return;
        }
        var mid = start + (end - start) / 2;
        BuildSegmentTree(2 * node + 1, start, mid, tree, baskets);
        BuildSegmentTree(2 * node + 2, mid + 1, end, tree, baskets);
        tree[node] = Math.Max(tree[2 * node + 1],tree[2 * node + 2]);        
    }
    public void UpdateNodeValue(int node, int start, int end, int idx, int[] tree)
    {
        if(start == end)
        {
            tree[node] = -1;
            return;
        }

        var mid = start + (end - start) / 2;
        if(start <= idx && idx <= mid)
            UpdateNodeValue(2 * node + 1, start, mid, idx, tree);
        else
            UpdateNodeValue(2 * node + 2, mid + 1, end, idx, tree);

        tree[node] = Math.Max(tree[2 * node + 1] , tree[2 * node + 2]);
    }

    public int FindLeftMost(int node, int start, int end, int targetValue, int[] tree)
    {
        if(tree[node] < targetValue)
            return -1;

        if(start == end)
            return start;

        var mid = start + (end - start) / 2;

        if(tree[2 * node + 1] >= targetValue)
            return FindLeftMost(2 * node + 1, start, mid, targetValue, tree);
        else
            return FindLeftMost(2 * node + 2, mid + 1, end, targetValue, tree);

    }
}