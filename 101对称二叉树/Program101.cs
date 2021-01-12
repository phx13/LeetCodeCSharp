using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101对称二叉树
{
    //给定一个二叉树，检查它是否是镜像对称的。



    //例如，二叉树[1, 2, 2, 3, 4, 4, 3] 是对称的。

    //    1
    //   / \
    //  2   2
    // / \ / \
    //3  4 4  3


    //但是下面这个[1, 2, 2, null, 3, null, 3] 则不是镜像对称的:

    //    1
    //   / \
    //  2   2
    //   \   \
    //   3    3


    //进阶：

    //你可以运用递归和迭代两种方法解决这个问题吗？

    class Program101
    {
        static void Main(string[] args)
        {
            var tree = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(4)
                },
                right = new TreeNode(2)
                {
                    left = new TreeNode(4),
                    right = new TreeNode(3)
                }
            };
            var res = IsSymmetric(tree);
            Console.WriteLine(res.ToString());
            Console.ReadKey();
        }

        public static bool IsSymmetric(TreeNode root)
        {
            return IsMirror(root, root);
        }

        public static bool IsMirror(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
            {
                return true;
            }
            else if (t1 == null || t2 == null)
            {
                return false;
            }
            else
            {
                if (t1.val == t2.val)
                {
                    return IsMirror(t1.left, t2.right) && IsMirror(t1.right, t2.left);
                }
                else
                {
                    return false;
                }
            }
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
