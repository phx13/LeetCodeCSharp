using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102二叉树的层序遍历
{
    //给你一个二叉树，请你返回其按 层序遍历 得到的节点值。 （即逐层地，从左到右访问所有节点）。



    //示例：
    //二叉树：[3,9,20,null,null,15,7],

    //    3
    //   / \
    //  9  20
    //    /  \
    //   15   7
    //返回其层序遍历结果：

    //[
    //  [3],
    //  [9,20],
    //  [15,7]
    //]

    class Program102
    {
        static void Main(string[] args)
        {
        }
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            var res = new List<IList<int>>();
            if (root == null)
            {
                return res;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            //BFS
            while (queue.Count != 0)
            {
                var size = queue.Count;
                var sublist = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    var treeNode = queue.Dequeue();
                    sublist.Add(treeNode.val);
                    if (treeNode.left != null)
                    {
                        queue.Enqueue(treeNode.left);
                    }
                    if (treeNode.right != null)
                    {
                        queue.Enqueue(treeNode.right);
                    }
                }
                res.Add(sublist);
            }
            return res;
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
