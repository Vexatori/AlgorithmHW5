using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmHW5
{
    public static class Postfix
    {
        /// <summary>
        /// Операторы и их приоритет
        /// </summary>
        private static Dictionary<char, int> ExpressionPriority = new Dictionary<char, int>
        {
            {'+', 2},
            {'-', 2},
            {'*', 3},
            {'/', 3},
            {'^', 4}
        };

        /// <summary>
        /// Метод возвращает приоритет текущего оператора
        /// </summary>
        /// <param name="operation">Проверяемый оператор</param>
        /// <returns></returns>
        private static int GetOperationPriority(char operation)
        {
            int priority = 0;
            foreach(var op in ExpressionPriority)
            {
                if(operation == op.Key)
                {
                    priority = op.Value;
                }
            }
            return priority;
        }

        /// <summary>
        /// Метод перестраивает входящую инфиксную запись в постфиксную
        /// </summary>
        /// <param name="str">Инфиксная запись выражения</param>
        /// <returns></returns>
        public static string RebuildToPostfix(string str)
        {
            Stack<(char, int)> op = new Stack<(char, int)>();
            string expression = string.Concat(str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            char[] temp = expression.ToCharArray();
            StringBuilder result = new StringBuilder();
            foreach(char sym in temp)
            {
                if(sym >= '0' && sym <= '9')
                {
                    result.Append(sym);
                }
                if(sym == '(')
                {
                    op.Push((sym, 0));
                }
                if(sym == ')')
                {
                    while(op.Peek().Item1 != '(')
                    {
                        result.Append(op.Pop().Item1);
                    }
                    if(op.Peek().Item1 == '(')
                    {
                        op.Pop();
                    }
                }
                if(ExpressionPriority.ContainsKey(sym))
                {
                    if(op.Count != 0)
                    {
                        while(op.Count != 0 && op.Peek().Item1 != '(' && op.Peek().Item2 >= GetOperationPriority(sym))
                        {
                            result.Append(op.Pop().Item1);
                        }
                    }
                    if(sym == '(')
                    {
                        op.Push((sym, 0));
                    }
                    op.Push((sym, GetOperationPriority(sym)));
                }
            }
            while(op.Count != 0)
            {
                result.Append(op.Pop().Item1);
            }
            return result.ToString();
        }
    }
}
