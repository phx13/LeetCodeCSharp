using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _337打家劫舍III
{
    //在上次打劫完一条街道之后和一圈房屋后，小偷又发现了一个新的可行窃的地区。这个地区只有一个入口，我们称之为“根”。 除了“根”之外，每栋房子有且只有一个“父“房子与之相连。一番侦察之后，聪明的小偷意识到“这个地方的所有房屋的排列类似于一棵二叉树”。 如果两个直接相连的房子在同一天晚上被打劫，房屋将自动报警。

    //计算在不触动警报的情况下，小偷一晚能够盗取的最高金额。

    //示例 1:

    //输入: [3,2,3,null,3,null,1]

    //     3
    //    / \
    //   2   3
    //    \   \ 
    //     3   1

    //输出: 7 
    //解释: 小偷一晚能够盗取的最高金额 = 3 + 3 + 1 = 7.
    //示例 2:

    //输入: [3,4,5,1,3,null,1]

    //     3
    //    / \
    //   4   5
    //  / \   \ 
    // 1   3   1

    //输出: 9
    //解释: 小偷一晚能够盗取的最高金额 = 4 + 5 = 9.

    class Program337
    {
        static void Main(string[] args)
        {
        }
        public static int Rob(TreeNode root)
        {

        }
        public static int[] DFS(TreeNode node)
        {
            if (node == null)
            {
                return new int[] { 0, 0 };
            }
            var left = DFS(node.left);
            var right = DFS(node.right);
            var select = node.val + left[1] + right[1];
            var notSelect = Math.Max(left[0], left[1]) + Math.Max(right[0], right[1]);
            return new int[] { select, notSelect };
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
