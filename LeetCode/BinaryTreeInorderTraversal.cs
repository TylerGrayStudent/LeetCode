using LeetCode.Shared;

namespace Leetcode;

public class BinaryTreeInorderTraversal
{
    public class Solution {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var order = GetTraversalOrder(root);
            return order;
        }

        public List<int> GetTraversalOrder(TreeNode root)
        {
            var res = new List<int>();
            if (root is null) return res;
            return res.Concat(GetTraversalOrder(root.left))
                .Concat(new List<int> {root.val})
                .Concat(GetTraversalOrder(root.right))
                .ToList();
        }
    }
}