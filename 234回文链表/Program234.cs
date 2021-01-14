using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _234回文链表
{
    //请判断一个链表是否为回文链表。

    //示例 1:

    //输入: 1->2
    //输出: false
    //示例 2:

    //输入: 1->2->2->1
    //输出: true
    //进阶：
    //你能否用 O(n) 时间复杂度和 O(1) 空间复杂度解决此题？

    class Program234
    {
        static void Main(string[] args)
        {
            var listNode = new ListNode(1)
            {
                next = new ListNode(3)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(1)
                    }
                }
            };
            Console.WriteLine(IsPalindrome(listNode).ToString());
            Console.ReadKey();
        }

        public static bool IsPalindrome(ListNode head)
        {
            //存数组，双指针
            var vals = new List<int>();
            var cur = head;
            while (cur != null)
            {
                vals.Add(cur.val);
                cur = cur.next;
            }
            var start = 0;
            var end = vals.Count - 1;
            while (start < end)
            {
                if (vals[start] != vals[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
