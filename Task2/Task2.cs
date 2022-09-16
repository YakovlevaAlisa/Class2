using System.Text;

namespace Task2
{
    public class Task2
    {

/*
 * В этих заданиях * рекомендуется всюду использовать класс StringBuilder.
 * Документация: https://docs.microsoft.com/ru-ru/dotnet/api/system.text.stringbuilder?view=net-6.0
 */

/*
 * Задание 2.1. Дана непустая строка S и целое число N (> 0). Вернуть строку, содержащую символы
 * строки S, между которыми вставлено по N символов «*» (звездочка).
 */
        internal static string FillWithAsterisks(string s, int n)
        {
            StringBuilder result = new StringBuilder();
            string insertingCharacters = new string('*', n);

            result.Append(s[0]);

            for (int i = 1; i < s.Length; i++)
            {
                result.Append(insertingCharacters + s[i]);
            }

            return result.ToString();
        }

        /*
         * Задание 2.2. Сформировать таблицу квадратов чисел от 1 до заданного числа N.
         * Например, для N=4 должна получиться следующая строка:

        1  1
        2  4
        3  9
        4 16

         * Обратите внимание на выравнивание: числа в первом столбце выравниваются по левому краю,
         * а числа во втором -- по правому, причём между числами должен оставаться как минимум один
         * пробел. В решении можно использовать функции Pad*.
         */
        internal static string TabulateSquares(int n)
        {
            int width = n.ToString().Length + (n*n).ToString().Length + 1;
            StringBuilder result = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                string space = new string(' ', width - (i * i).ToString().Length - i.ToString().Length);

                result.Append(i + space + i*i + '\n');
            }

            return result.Remove(result.Length - 1, 1).ToString();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(FillWithAsterisks("abc", 2));

            Console.WriteLine(TabulateSquares(4));

        }
    }
}