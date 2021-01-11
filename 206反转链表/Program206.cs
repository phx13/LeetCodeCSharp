using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _206反转链表
{
    //反转一个单链表。

    //示例:

    //输入: 1->2->3->4->5->NULL
    //输出: 5->4->3->2->1->NULL
    class Program206
    {
        static void Main(string[] args)
        {
            var l = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                            {
                                next = null
                            }
                        }
                    }
                }
            };
            var res = ReverseList(l);
            while (res != null)
            {
                Console.Write(res.val);
                res = res.next;
            }
            Console.ReadKey();
        }

        public static ListNode ReverseList(ListNode head)
        {
            //迭代
            ListNode prev = null;
            ListNode cur = head;
            while (cur != null)
            {
                ListNode nextNode = cur.next;
                cur.next = prev;
                prev = cur;
                cur = nextNode;
            }
            return prev;

            ////递归
            //if (head == null || head.next == null)
            //{
            //    return head;
            //}
            //ListNode newHead = ReverseList(head.next);
            
            //head.next.next = head;
            //head.next = null;

            //return newHead;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
