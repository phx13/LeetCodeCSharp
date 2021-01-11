using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021合并两个有序链表
{
    //将两个升序链表合并为一个新的 升序 链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 

    //1->2->4
    //1->3->4
    //1->1->2->3->4->4

    //示例 1：
    //输入：l1 = [1,2,4], l2 = [1,3,4]
    //输出：[1,1,2,3,4,4]

    //示例 2：
    //输入：l1 = [], l2 = []
    //输出：[]

    //示例 3：
    //输入：l1 = [], l2 = [0]
    //输出：[0]


    //提示：

    //两个链表的节点数目范围是[0, 50]
    //-100 <= Node.val <= 100
    //l1 和 l2 均按 非递减顺序 排列

    class Program021
    {
        static void Main(string[] args)
        {
            var l1 = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 2,
                    next = new ListNode()
                    {
                        val = 4
                    }
                }
            };
            var l2 = new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 3,
                    next = new ListNode()
                    {
                        val = 4
                    }
                }
            };
            var res = MergeTwoLists(l1, l2);
            while (res != null)
            {
                Console.Write(res.val);
                res = res.next;
            }
            Console.ReadKey();
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var res = new ListNode(0);
            var currentNode = res;
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    currentNode.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    currentNode.next = l2;
                    l2 = l2.next;
                }
                currentNode = currentNode.next;
            }

            if (l1 == null)
            {
                currentNode.next = l2;
            }
            else
            {
                currentNode.next = l1;
            }

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
