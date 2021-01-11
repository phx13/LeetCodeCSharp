using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104二叉树的最大深度
{
    //给定一个二叉树，找出其最大深度。

    //二叉树的深度为根节点到最远叶子节点的最长路径上的节点数。

    //说明: 叶子节点是指没有子节点的节点。

    //示例：
    //给定二叉树 [3,9,20,null,null,15,7]，

    //    3
    //   / \
    //  9  20
    //    /  \
    //   15   7
    //返回它的最大深度 3 。
    class Program104
    {
        static void Main(string[] args)
        {
        }

        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int leftDepth = MaxDepth(root.left);
                int rightDepth = MaxDepth(root.right);
                return Math.Max(leftDepth, rightDepth) + 1;
            }
        }
    }
    public class TreeNode
    {
        public int val;//节点值
        public TreeNode left;//左节点
        public TreeNode right;//右节点
        public TreeNode(int x) { val = x; }//节点构造函数
    }
}
