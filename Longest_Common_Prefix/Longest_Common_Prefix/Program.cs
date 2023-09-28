using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = new string[2] {"clar","cli"};
            Console.WriteLine(LongestCommonPrefix(strs));
            Console.ReadKey();
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            string result = "";
            for (int i = 0; i < MinOfStrs(strs).Length; i++)
            {
                if (CommonElement(strs, 0) == "")
                {
                    result = "";
                    break;
                }
                if (CommonElement(strs, i) == "")
                {
                    result += "";
                    break;
                }
                result += CommonElement(strs, i);
            }
            return result;
        }
        public static string CommonElement(string[] strs, int to_next)
        {
            string elements = "";
            string check_equals_elements;

            for (int i = 0; i < strs.Length ; i++)          // Запись всех iых элементов  в строку
            {
                elements += strs[i][to_next];
            }

            check_equals_elements = elements[0].ToString();

            for (int j = 0; j < elements.Length - 1; j++)     // Проверка что в строке все одинаковые элементы
            {
                if (elements.Length == 1)
                {
                    break;
                }
                if (elements[j] == elements[j + 1])
                {
                    check_equals_elements = elements[j + 1].ToString();
                }
                else
                {
                    check_equals_elements = "";
                    break;
                }
            }
            return check_equals_elements;
        }
        public static string MinOfStrs(string[] strs)
        {
            string result = "";

            for (int i = 1; i < strs.Length; i++)
            {
                
                if (strs[0].Length > strs[i].Length)
                {
                    result = strs[i];
                    strs[i] = strs[0];
                    strs[0] = result;
                }
                else
                {
                    result = strs[0];
                }
            }
            if (strs.Length == 1)
            {
                result = strs[0];
            }
            return result;
        }
    }
}
