using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_programming
{
    /**
    * Definition for a binary tree node. */
    class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    class Solution
    {
        int level = -1;
        int result = 0;
        public int FindBottomLeftValue(TreeNode root)
        {
            if (root == null)
            {
                return result;
            }
            LeftFirstTranverse(root, 0);
            return result;
        }
        private void LeftFirstTranverse(TreeNode root, int currentlevel)
        {
            if (root == null)
                return;
            if (currentlevel > level)
            {
                result = root.val;
                level = currentlevel;
            }
            LeftFirstTranverse(root.left, currentlevel + 1);
            LeftFirstTranverse(root.right, currentlevel + 1);
        }
    }
    class FindBottomLeftTreeValue
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            TreeNode root = new TreeNode(1), p;
            p = new TreeNode(2);
            root.left = p;
            p = new TreeNode(3);
            root.right = p;
            p = new TreeNode(4);
            root.left.left = p;
            p = new TreeNode(5);
            root.right.left = p;
            p = new TreeNode(6);
            root.right.right = p;
            p = new TreeNode(7);
            root.right.left.left = p;
            Console.WriteLine(solution.FindBottomLeftValue(root));
            Console.ReadKey();
        }
    }
}
