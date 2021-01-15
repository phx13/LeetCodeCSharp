using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _114二叉树展开为链表
{
    //给定一个二叉树，原地将它展开为一个单链表。



    //例如，给定二叉树

    //    1
    //   / \
    //  2   5
    // / \   \
    //3   4   6
    //将其展开为：

    //1
    // \
    //  2
    //   \
    //    3
    //     \
    //      4
    //       \
    //        5
    //         \
    //          6

    class Program114
    {
        static void Main(string[] args)
        {
            var root = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(4)
                },
                right = new TreeNode(5)
                {
                    right = new TreeNode(6)
                }
            };
            Flatten(root);
        }
        public static void Flatten(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            var path = new Stack<TreeNode>();
            TreeNode p = null;
            DFS(root, path);
            while (path.Count > 0)
            {
                var newTree = path.Pop();
                newTree.left = null;
                newTree.right = p;
                p = newTree;
            }
        }

        private static void DFS(TreeNode root, Stack<TreeNode> path)
        {
            if (root == null)
            {
                return;
            }
            path.Push(root);
            DFS(root.left, path);
            DFS(root.right, path);
        }
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
