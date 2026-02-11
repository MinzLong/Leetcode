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
    public int MaxLevelSum(TreeNode root) {
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        int level = 0;
        int bestLevel = 1;
        long maxSum = long.MinValue;

        while(q.Count >0){
            level++;
            int size = q.Count;
            long sum = 0;

            for(int i = 0; i<size; i++){
                var node = q.Dequeue();
                sum += node.val;

                if(node.left != null) q.Enqueue(node.left);
                if(node.right != null) q.Enqueue(node.right);
            }
            if (sum>maxSum){
                maxSum = sum;
                bestLevel = level;
            }
        }
                return bestLevel;
    }
}