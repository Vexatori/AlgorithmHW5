using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlgorithmHW5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача о переводе из инфиксной записи в постфиксную
            ////string str = "3 + 4 * 2 / ( 1 - 5 ) ^ 2";
            ////string str = "( 1+ 2) * 4+3";
            //string str = "1+2*3";
            //Console.WriteLine(Postfix.RebuildToPostfix(str));
            #endregion

            #region Пример работы копирования односвязного списка
            ////Не уверен, что правильно понял задание
            //TNode temp = new TNode();
            //temp.Value = 1;
            //temp.Next = new TNode();
            //temp.Next.Value = 5;
            //TNode buf = (TNode)temp.Clone();
            ////buf.Value = 2;
            ////buf.Next.Value = 14;
            //Console.WriteLine($"Значение в temp {temp.Value} ; Значение в buf {buf.Value}");
            //Console.WriteLine($"Значение в temp.Next {temp.Next.Value} ; Значение в buf.Next {buf.Next.Value}");
            #endregion

            #region Перевод в двоичную систему счисления
            //Console.WriteLine(ToBinary.Convert(14));
            #endregion

            #region Определение правильности последовательности скобок
            //string chain = "({})()[]{}";
            //string chain = "{){][)()[";
            //Console.WriteLine($"Последовательность верна? => {BracketChain.IsCorrect(chain)}");
            #endregion

            Console.ReadLine();
        }
    }
}
