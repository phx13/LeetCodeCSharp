using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _399除法求值
{
    //给你一个变量对数组 equations 和一个实数值数组 values 作为已知条件，其中 equations[i] = [Ai, Bi] 和 values[i] 共同表示等式 Ai / Bi = values[i] 。每个 Ai 或 Bi 是一个表示单个变量的字符串。

    //另有一些以数组 queries 表示的问题，其中 queries[j] = [Cj, Dj] 表示第 j 个问题，请你根据已知条件找出 Cj / Dj = ? 的结果作为答案。

    //返回 所有问题的答案 。如果存在某个无法确定的答案，则用 -1.0 替代这个答案。如果问题中出现了给定的已知条件中没有出现的字符串，也需要用 -1.0 替代这个答案。

    //注意：输入总是有效的。你可以假设除法运算中不会出现除数为 0 的情况，且不存在任何矛盾的结果。



    //示例 1：

    //输入：equations = [["a","b"],["b","c"]], values = [2.0,3.0], queries = [["a","c"],["b","a"],["a","e"],["a","a"],["x","x"]]
    //输出：[6.00000,0.50000,-1.00000,1.00000,-1.00000]
    //    解释：
    //条件：a / b = 2.0, b / c = 3.0
    //问题：a / c = ?, b / a = ?, a / e = ?, a / a = ?, x / x = ?
    //结果：[6.0, 0.5, -1.0, 1.0, -1.0 ]
    //    示例 2：

    //输入：equations = [["a","b"],["b","c"],["bc","cd"]], values = [1.5,2.5,5.0], queries = [["a","c"],["c","b"],["bc","cd"],["cd","bc"]]
    //输出：[3.75000,0.40000,5.00000,0.20000]
    //    示例 3：

    //输入：equations = [["a","b"]], values = [0.5], queries = [["a","b"],["b","a"],["a","c"],["x","y"]]
    //输出：[0.50000,2.00000,-1.00000,-1.00000]


    //    提示：

    //1 <= equations.length <= 20
    //equations[i].length == 2
    //1 <= Ai.length, Bi.length <= 5
    //values.length == equations.length
    //0.0 < values[i] <= 20.0
    //1 <= queries.length <= 20
    //queries[i].length == 2
    //1 <= Cj.length, Dj.length <= 5
    //Ai, Bi, Cj, Dj 由小写英文字母与数字组成

    class Program399
    {
        static void Main(string[] args)
        {
        }
        public static double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            int equationsSize = equations.Count;
            //用数组实现并查集（将多个树组成的森林结构简化为用数组表示），数组大小即为所有节点的个数
            UnionFind unionFind = new UnionFind(equationsSize * 2);
            //将变量字符串映射为id，方便操作数组
            Dictionary<string, int> dicMap = new Dictionary<string, int>(equationsSize * 2);
            int id = 0;
            for (int i = 0; i < equationsSize; i++)
            {
                string str1 = equations[i][0],
                    str2 = equations[i][1];
                if (!dicMap.ContainsKey(str1))
                {
                    dicMap.Add(str1, id);
                    id++;
                }
                if (!dicMap.ContainsKey(str2))
                {
                    dicMap.Add(str2, id);
                    id++;
                }
                //将两个节点进行一次合并，
                unionFind.union(dicMap[str1], dicMap[str2], values[i]);
            }
            //查询节点
            int queriesSize = queries.Count;
            double[] result = new double[queriesSize];
            for (int i = 0; i < queriesSize; i++)
            {
                string str1 = queries[i][0],
                    str2 = queries[i][1];
                int id1 = -1, id2 = -1;
                if (dicMap.ContainsKey(str1))
                    id1 = dicMap[str1];
                if (dicMap.ContainsKey(str2))
                    id2 = dicMap[str2];
                //若查询节点不在给定的节点中，比值则为-1
                if (id1 < 0 || id2 < 0)
                    result[i] = -1.0;
                else
                    result[i] = unionFind.isConnected(id1, id2); //结果为两个查询节点到根节点有向边的权值比值
            }
            return result;
        }
    }
    public class UnionFind
    {
        //数组（所有节点组成的各个树的森林）
        private int[] parent;
        //节点到根节点有向边的权值
        private double[] weight;
        public UnionFind(int size)
        {
            //初始化
            parent = new int[size];
            weight = new double[size];
            for (int i = 0; i < size; i++)
            {
                parent[i] = i;
                weight[i] = 1.0;
            }
        }
        public void union(int x, int y, double value)
        {
            int rootX = find(x);
            int rootY = find(y);
            //两个节点指向的根节点相等，无需合并
            if (rootX == rootY)
            {
                return;
            }
            //合并，将x的根节点指向y的根节点
            parent[rootX] = parent[rootY];
            //计算权值，由：value * weight[y] = weight[x] * weight[rootX] 进行推到
            //即：x->y的权值 * y->Yroot的权值 = x->Xroot的权值 * Xroot->Yroot的权值
            weight[rootX] = weight[y] * value / weight[x];
        }

        //查找节点的根节点，查找过程实现路径压缩，即将该树中该节点的深度转换为2
        public int find(int x)
        {
            if (x != parent[x])
            {
                int origin = parent[x];
                //递归找到根节点,并将其作为查找节点x的根节点
                parent[x] = find(parent[x]);
                //权值维护,节点到根节点所有路径上的权值乘积
                weight[x] *= weight[origin];
            }
            return parent[x];
        }

        public double isConnected(int x, int y)
        {
            int rootX = find(x);
            int rootY = find(y);
            //同一个树中，则连通，返回权值比，否则不连通，返回-1
            if (rootX == rootY)
                return weight[x] / weight[y];
            else
                return -1.0;
        }
    }
}
