using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dfhrrthrh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            //Разбивает строку на максимальное число подстрок на основе указанного символа-разделителя, до пустого "пространства"
            string[] str = input.Split(new Char[] { ' ', }, StringSplitOptions.RemoveEmptyEntries);

            // максимал кол во знаков
            int maxlen = 0, index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlen)
                {
                    maxlen = str[i].Length;
                    index = i;
                }
            }
            Console.Write("Самое длинное слово: {0}", str[index]);
            Console.ReadLine();
        }
    }
}
