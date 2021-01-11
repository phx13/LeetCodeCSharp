using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _617合并二叉树
{
    //给定两个二叉树，想象当你将它们中的一个覆盖到另一个上时，两个二叉树的一些节点便会重叠。

    //你需要将他们合并为一个新的二叉树。合并的规则是如果两个节点重叠，那么将他们的值相加作为节点合并后的新值，否则不为 NULL 的节点将直接作为新二叉树的节点。

    //示例 1:

    //输入: 
    //	Tree 1                     Tree 2                  
    //          1                         2                             
    //         / \                       / \                            
    //        3   2                     1   3                        
    //       /                           \   \                      
    //      5                             4   7                  
    //输出: 
    //合并后的树:
    //	     3
    //	    / \
    //	   4   5
    //	  / \   \ 
    //	 5   4   7
    //注意: 合并必须从两个树的根节点开始。

    class Program617
    {
        static void Main(string[] args)
        {
            var t1 = new TreeNode(1) { left = new TreeNode(3) { left = new TreeNode(5) }, right = new TreeNode(2) };
            var t2 = new TreeNode(2) { left = new TreeNode(1) { right = new TreeNode(4) }, right = new TreeNode(3) { right = new TreeNode(7) } };

            MergeTrees(t1, t2);
        }

        public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
            {
                return null;//如果两个节点都为null，返回null
            }
            if (t1 == null)
            {
                return t2;//如果t1为null，返回t2
            }
            if (t2 == null)
            {
                return t1;//如果t2为null，返回t1
            }

            //否则
            t1.val += t2.val;//两值相加
            t1.left = MergeTrees(t1.left, t2.left);//递归左节点
            t1.right = MergeTrees(t1.right, t2.right);//递归右节点
            return t1;//返回t1
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
