using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _148排序链表
{
    //给你链表的头结点 head ，请将其按 升序 排列并返回 排序后的链表 。

    //进阶：

    //你可以在 O(n log n) 时间复杂度和常数级空间复杂度下，对链表进行排序吗？


    //示例 1：


    //输入：head = [4,2,1,3]
    //    输出：[1,2,3,4]
    //    示例 2：


    //输入：head = [-1,5,3,4,0]
    //    输出：[-1,0,3,4,5]
    //    示例 3：

    //输入：head = []
    //    输出：[]


    //    提示：

    //链表中节点的数目在范围[0, 5 * 104] 内
    //-105 <= Node.val <= 105

    class Program148
    {
        static void Main(string[] args)
        {
        }
        public ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            //快慢指针
            var pSlow = head;
            var pFast = head;

            //找中点
            while (pFast.next != null && pFast.next.next != null)
            {
                pSlow = pSlow.next;
                pFast = pFast.next.next;
            }

            //一分为二，取出后半段
            var temp = pSlow.next;
            pSlow.next = null;

            //递归以上步骤
            var pLeft = SortList(head);
            var pRight = SortList(temp);

            //合并
            var res = new ListNode(0);
            var cur = res;
            while (pLeft != null && pRight != null)
            {
                if (pLeft.val < pRight.val)
                {
                    cur.next = pLeft;
                    pLeft = pLeft.next;
                }
                else
                {
                    cur.next = pRight;
                    pRight = pRight.next;
                }
                cur = cur.next;
            }

            cur.next = pLeft != null ? pLeft : pRight;
            return res.next;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
