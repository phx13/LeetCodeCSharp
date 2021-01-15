using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _208实现Trie_前缀树_
{
    //实现一个 Trie (前缀树)，包含 insert, search, 和 startsWith 这三个操作。

    //示例:

    //Trie trie = new Trie();

    //trie.insert("apple");
    //trie.search("apple");   // 返回 true
    //trie.search("app");     // 返回 false
    //trie.startsWith("app"); // 返回 true
    //trie.insert("app");   
    //trie.search("app");     // 返回 true
    //说明:

    //你可以假设所有的输入都是由小写字母 a-z 构成的。
    //保证所有输入均为非空字符串。

    class Program208
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();

            trie.Insert("apple");
            Console.WriteLine(trie.Search("apple").ToString());   // 返回 true
            Console.WriteLine(trie.Search("app").ToString());     // 返回 false
            Console.WriteLine(trie.StartsWith("app").ToString()); // 返回 true
            trie.Insert("app");
            Console.WriteLine(trie.Search("app").ToString());     // 返回 true
            Console.ReadKey();
        }
    }
    public class Trie
    {
        private TrieNode root;

        /** Initialize your data structure here. */
        public Trie()
        {
            root = new TrieNode();
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            var trieNode = root;
            foreach (var letter in word)
            {
                if (!trieNode.ContainsKey(letter))
                {
                    trieNode.InsertKey(letter, new TrieNode());
                }
                trieNode = trieNode.GetKey(letter);
            }
            trieNode.SetEnd();
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            var trieNode = root;
            foreach (var letter in word)
            {
                if (!trieNode.ContainsKey(letter))
                {
                    return false;
                }
                trieNode = trieNode.GetKey(letter);
            }
            return trieNode.GetEnd();
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            var trieNode = root;
            foreach (var letter in prefix)
            {
                if (!trieNode.ContainsKey(letter))
                {
                    return false;
                }
                trieNode = trieNode.GetKey(letter);
            }
            return true;
        }
    }

    public class TrieNode
    {
        private TrieNode[] trieNodes;
        private bool isEnd;
        private int n = 26;
        public TrieNode()
        {
            trieNodes = new TrieNode[n];
        }
        public bool ContainsKey(char c)
        {
            return trieNodes[c - 'a'] != null;
        }
        public TrieNode GetKey(char c)
        {
            return trieNodes[c - 'a'];
        }
        public void InsertKey(char c, TrieNode trieNode)
        {
            trieNodes[c - 'a'] = trieNode;
        }
        public void SetEnd()
        {
            isEnd = true;
        }
        public bool GetEnd()
        {
            return isEnd;
        }
    }
}
