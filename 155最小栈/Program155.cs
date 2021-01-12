using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _155最小栈
{
    //设计一个支持 push ，pop ，top 操作，并能在常数时间内检索到最小元素的栈。

    //push(x) —— 将元素 x 推入栈中。
    //pop() —— 删除栈顶的元素。
    //top() —— 获取栈顶元素。
    //getMin() —— 检索栈中的最小元素。


    //示例:

    //输入：
    //["MinStack","push","push","push","getMin","pop","top","getMin"]
    //    [[],[-2],[0],[-3],[],[],[],[]]

    //输出：
    //[null,null,null,null,-3,null,0,-2]

    //    解释：
    //MinStack minStack = new MinStack();
    //minStack.push(-2);
    //minStack.push(0);
    //minStack.push(-3);
    //minStack.getMin();   --> 返回 -3.
    //minStack.pop();
    //minStack.top();      --> 返回 0.
    //minStack.getMin();   --> 返回 -2.


    //提示：

    //pop、top 和 getMin 操作总是在 非空栈 上调用。

    class Program155
    {
        static void Main(string[] args)
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            Console.WriteLine(minStack.GetMin());
            minStack.Pop();
            Console.WriteLine(minStack.Top());
            Console.WriteLine(minStack.GetMin());
            Console.ReadKey();
        }
    }

    public class MinStack
    {
        private Stack<int> stack;
        public MinStack()
        {
            stack = new Stack<int>();
        }

        public void Push(int x)
        {
            stack.Push(x);
            Console.WriteLine("null");
        }

        public void Pop()
        {
            stack.Pop();
            Console.WriteLine("null");
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return stack.Min();
        }
    }
}
