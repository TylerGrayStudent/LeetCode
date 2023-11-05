using LeetCode.Shared;

namespace Leetcode;

public class SameTree
{
    public class Solution {
        public bool IsSameTree(TreeNode p, TreeNode q) {
            if(p is null && q is null) return true;
            return p?.val == q?.val && IsSameTree(p?.left, q?.left) && IsSameTree(p?.right, q?.right);
        }
    }
}