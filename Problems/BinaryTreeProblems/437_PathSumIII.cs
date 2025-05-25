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
public class PathSum_Solution
{
    public int PathSum(TreeNode root, int targetSum)
    {
        //Do base check here
        if (root == null)
        {
            return 0;
        }
        int pathFromRoot = DfsCountPathSums(root, (long)targetSum);
        int pathsFromLeftSubtree = PathSum(root.left, targetSum);
        int pathsFromRightSubtree = PathSum(root.right, targetSum); 

        return pathFromRoot + pathsFromLeftSubtree + pathsFromRightSubtree;

    }

    private int DfsCountPathSums(TreeNode currentNode, long diff)
    {
        if (currentNode == null)
        {
            return 0;
        }

        int pathCount = 0;

        if (currentNode.val == diff)
        {
            pathCount++;
        }
        pathCount += DfsCountPathSums(currentNode.left, diff - currentNode.val);
        pathCount += DfsCountPathSums(currentNode.right, diff - currentNode.val);


        return pathCount;
    }
}