using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmHW5
{
    public static class BracketChain
    {
        /// <summary>
        /// Метод возвращает true, если текущая последовательность скобок правильная, и false, если она неправильная
        /// </summary>
        /// <param name="chain"></param>
        /// <returns></returns>
        public static bool IsCorrect(string chain)
        {
            char[] chainArr = chain.ToCharArray();
            Stack<char> stack = new Stack<char>();
            for(int i = 0; i < chainArr.Length; i++)
            {
                if(chainArr[ i ] == '(' || chainArr[ i ] == '{' || chainArr[ i ] == '[')
                {
                    stack.Push(chainArr[ i ]);
                }
                else
                {
                    if(chainArr[ i ] == ')' && stack.Count != 0 && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else if(chainArr[ i ] == '}' && stack.Count != 0 && stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else if(chainArr[ i ] == ']' && stack.Count != 0 && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else if(( chainArr[ i ] == '}' || chainArr[ i ] == ')' || chainArr[ i ] == ']') && stack.Count == 0)
                    {
                        stack.Push('e');
                        break;
                    }
                }
            }
            if(stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
