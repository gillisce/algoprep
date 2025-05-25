public class RightSide_Solution {
    public IList<int> RightSideView(TreeNode root)
    {
        List<int> result = new();
        if (root == null)
        {
            return result;
        }
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            for (int i = 0; i < levelSize; i++)
            {
                TreeNode node = queue.Dequeue();
                if (i == levelSize - 1)
                {
                    result.Add(node.val);
                }
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
        }


        return result;
    }
}