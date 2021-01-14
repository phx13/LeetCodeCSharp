using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _094二叉树的中序遍历
{
    //给定一个二叉树的根节点 root ，返回它的 中序 遍历。



    //示例 1：


    //输入：root = [1,null,2,3]
    //输出：[1,3,2]
    //示例 2：

    //输入：root = []
    //输出：[]
    //示例 3：

    //输入：root = [1]
    //输出：[1]
    //示例 4：


    //输入：root = [1,2]
    //输出：[2,1]
    //示例 5：


    //输入：root = [1,null,2]
    //输出：[1,2]


    //提示：

    //树中节点数目在范围[0, 100] 内
    //-100 <= Node.val <= 100


    //进阶: 递归算法很简单，你可以通过迭代算法完成吗？

    class Program094
    {
        static void Main(string[] args)
        {
        }
        public static IList<int> InorderTraversal(TreeNode root)
        {
            var res = new List<int>();

            return res;
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
