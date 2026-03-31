using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.LeetCode150
{
    public class goodNodes
    {
        public static int GoodNodes(TreeNode root)
        {
            if (root == null) return 0;
            return DFS(root, root.val);
        }

        private static int DFS(TreeNode curr, int max)
        {
            if (curr == null)
                return 0;

            int count = 0;

            if (curr.val >= max)
                count++;

            max = Math.Max(max, curr.val);

            count += DFS(curr.left, max);
            count += DFS(curr.right, max);

            return count;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }

}
