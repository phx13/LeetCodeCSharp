using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _105从前序与中序遍历序列构造二叉树
{
    //根据一棵树的前序遍历与中序遍历构造二叉树。

    //注意:
    //你可以假设树中没有重复的元素。

    //例如，给出

    //前序遍历 preorder = [3,9,20,15,7]
    //中序遍历 inorder = [9, 3, 15, 20, 7]
    //返回如下的二叉树：

    //    3
    //   / \
    //  9  20
    //    /  \
    //   15   7

    class Program105
    {
        static void Main(string[] args)
        {
        }
        public static TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length != inorder.Length)
            {
                return null;
            }
            var inDict = new Dictionary<int, int>();
            for (int i = 0; i < inorder.Length; i++)
            {
                inDict.Add(inorder[i], i);
            }

            return MyBuildTree(preorder, 0, preorder.Length - 1, inDict, 0, inDict.Count - 1);
        }

        private static TreeNode MyBuildTree(int[] preorder, int preLeft, int preRight, Dictionary<int, int> inDict, int inLeft, int inRight)
        {
            if (preLeft > preRight || inLeft > inRight)
            {
                return null;
            }
            var rootVal = preorder[preLeft];
            var pIndex = inDict[rootVal];
            var root = new TreeNode(rootVal);

            root.left = MyBuildTree(preorder, preLeft + 1, pIndex - inLeft + preLeft, inDict, inLeft, pIndex - 1);
            root.right = MyBuildTree(preorder, pIndex - inLeft + preLeft + 1, preRight, inDict, pIndex + 1, inRight);
            return root;
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
