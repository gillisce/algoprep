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
public class LeafSimilar_Solution
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        if (root1 == null || root2 == null)
        {
            return false;
        }
        List<int> root1Leafs = new();
        List<int> root2Leafs = new();
        GetLeafHelper(root1, root1Leafs);
        GetLeafHelper(root2, root2Leafs);


        return root1Leafs.SequenceEqual(root2Leafs);
    }

    private void GetLeafHelper(TreeNode node, List<int> list)
    {
        if (node == null)
        {
            return;
        }
        GetLeafHelper(node.left, list);
        if (node.right == null && node.left == null)
        {
            list.Add(node.val);
        }
        GetLeafHelper(node.right, list);
    }
}