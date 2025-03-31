using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Solution.BracketValidation
{
    public class BracketValidator
    {
        private class Node
        {
            public char Data;
            public Node Next;
            public Node(char data)
            {
                Data = data;
                Next = null;
            }
        }
        private Node top;
        public BracketValidator()
        {
            top = null;
        }
        public void Push(char item)
        {
            Node newNode = new Node(item);
            newNode.Next = top;
            top = newNode;
        }
        public char Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack kosong!");

            char item = top.Data;
            top = top.Next;
            return item;
        }
        public bool IsEmpty()
        {
            return top == null;
        }
        public static bool ValidasiEkspresi(string ekspresi)
        {
            BracketValidator stack = new BracketValidator();
            foreach (char ch in ekspresi)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.IsEmpty()) return false;

                    char topChar = stack.Pop();
                    if ((ch == ')' && topChar != '(') ||
                        (ch == '}' && topChar != '{') ||
                        (ch == ']' && topChar != '['))
                    {
                        return false;
                    }
                }
            }
            return stack.IsEmpty();
        }
    }
}