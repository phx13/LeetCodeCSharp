using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226翻转二叉树
{
    //翻转一棵二叉树。

    //示例：

    //输入：

    //     4
    //   /   \
    //  2     7
    // / \   / \
    //1   3 6   9
    //输出：

    //     4
    //   /   \
    //  7     2
    // / \   / \
    //9   6 3   1

    class Program226
    {
        static void Main(string[] args)
        {

        }

        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            else
            {
                var temp = root.left;
                root.left = root.right;
                root.right = temp;

                root.left = InvertTree(root.left);
                root.right = InvertTree(root.right);
                return root;
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
