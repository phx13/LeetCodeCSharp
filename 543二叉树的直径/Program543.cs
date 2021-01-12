using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _543二叉树的直径
{
    //给定一棵二叉树，你需要计算它的直径长度。一棵二叉树的直径长度是任意两个结点路径长度中的最大值。这条路径可能穿过也可能不穿过根结点。



    //示例 :
    //给定二叉树

    //          1
    //         / \
    //        2   3
    //       / \     
    //      4   5    
    //返回 3, 它的长度是路径[4, 2, 1, 3] 或者[5, 2, 1, 3]。



    //注意：两结点之间的路径长度是以它们之间边的数目表示。

    class Program543
    {
        static void Main(string[] args)
        {
            var tree = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4),
                    right = new TreeNode(5)
                },
                right = new TreeNode(3)
            };
            Console.WriteLine(DiameterOfBinaryTree(tree));
            Console.ReadKey();
        }
        public static int max;
        public static int DiameterOfBinaryTree(TreeNode root)
        {
            max = 0;
            Depth(root);
            return max;
        }
        public static int Depth(TreeNode treeNode)
        {
            if (treeNode == null)
            {
                return 0;
            }
            var l = Depth(treeNode.left);
            var r = Depth(treeNode.right);
            if (l + r > max)
            {
                max = l + r;
            }
            return Math.Max(l, r) + 1;
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
