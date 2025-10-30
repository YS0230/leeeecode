/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        if(root == null) return new List<IList<int>>();
        var res = new List<IList<int>>();
        //DFS(root, 1, res);
        var qu = new Queue<TreeNode>();
        qu.Enqueue(root);
        while(qu.Count > 0)
        {
            var levelSize = qu.Count;
            var curLevelList = new List<int>();
            while(levelSize > 0)
            {
                var node = qu.Dequeue();
                curLevelList.Add(node.val);
                if(node.left != null) qu.Enqueue(node.left);
                if(node.right != null) qu.Enqueue(node.right);
                levelSize--;
            }
            res.Add(curLevelList);
        }
        return res;
                
    }
    public void DFS(TreeNode node,int idx, List<IList<int>> res)
    {
        if(node == null) return;
        if(idx > res.Count)
        {
            res.Add(new List<int>(){node.val});
        }
        else
        {
            res[idx - 1].Add(node.val);
        }
        DFS(node.left, idx + 1, res);
        DFS(node.right, idx + 1, res);
    }
}