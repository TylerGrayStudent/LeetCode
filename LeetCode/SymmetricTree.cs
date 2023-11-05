using LeetCode.Shared;

namespace Leetcode;

public class SymmetricTree
{
    public class Solution {
        public bool IsSymmetric(TreeNode root)
        {
            return IsFlipFlop(root?.left, root?.right);
        }
        
        public bool IsFlipFlop(TreeNode p, TreeNode q) {
            if(p is null && q is null) return true;
            return p?.val == q?.val && IsFlipFlop(p?.left, q?.right) && IsFlipFlop(p?.right, q?.left);
        }
    }
}