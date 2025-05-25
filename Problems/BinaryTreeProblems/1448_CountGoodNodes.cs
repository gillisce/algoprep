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
public class CountGoodNodes_Solution
{
    //Without testing I was close, just didn't think through the exact recurisve logic for counts
    // public int GoodNodes(TreeNode root)
    // {
    //     if (root == null) return 0;
    //     int count = dfs(root, root, 0);

    //     return count;
    // }

    // public int dfs(TreeNode node, TreeNode prev, int count)
    // {
    //     if (node == null) return 0;
    //     if (node.val >= prev.val)
    //     {
    //         return 1 + count;
    //     }
    //     int leftCount = dfs(node.left, node, count);
    //     int rightCount = dfs(node.right, node, count);

    //     return leftCount + rightCount;

    // }

    public int GoodNodes(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        return DfsCountGoodNodes(root, root.val);
    }

  
    private int DfsCountGoodNodes(TreeNode current_node, int max_val_on_path)
    {
        if (current_node == null)
        {
            return 0;
        }

        int goodNodesCount = 0;
        if (current_node.val >= max_val_on_path)
        {
            goodNodesCount = 1; 
            max_val_on_path = current_node.val;
        }


        int new_max_for_children = Math.Max(max_val_on_path, current_node.val);


        // Recursively count good nodes in the left and right subtrees
        goodNodesCount += DfsCountGoodNodes(current_node.left, new_max_for_children);
        goodNodesCount += DfsCountGoodNodes(current_node.right, new_max_for_children);

        // Return the total count for the subtree rooted at current_node
        return goodNodesCount;
    }
}