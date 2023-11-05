using LeetCode.Shared;

namespace Leetcode;

public class MaximumDepthOfBinaryTree
{
    public class Solution {
        public int MaxDepth(TreeNode root)
        {
            return root is null ? 0 : Math.Max(MaxDepth(root?.left) ,MaxDepth(root?.right)) + 1;
        }
    }
}