using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmHW5
{
    public static class ToBinary
    {
        /// <summary>
        /// Метод конвертирует заданное десятичное число в двоичное
        /// </summary>
        /// <param name="num">Число в десятичной системе счисления</param>
        /// <returns></returns>
        public static string Convert(int num)
        {
            StringBuilder result = new StringBuilder();
            Stack<int> temp = new Stack<int>();
            while(num != 0)
            {
                int buf = num % 2;
                num /= 2;
                temp.Push(buf);
            }
            foreach(int t in temp)
            {
                result.Append(t.ToString());
            }
            return result.ToString();
        }
    }
}
