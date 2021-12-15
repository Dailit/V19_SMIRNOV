using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Z01(StringBuilder builder)
        {
            var count = 0;
            while (builder.Length > 0)
            {
                count++;
                builder.Replace(new string(builder[0], 1), "");
            }

            Console.WriteLine(count);
        }
        static void Z02(StringBuilder builder)
        {
            List<string> lst = builder.ToString().Split(' ').ToList();
            lst = lst.OrderBy(x => x.Length).ToList();
            Console.WriteLine(string.Join(" ", lst));
            Console.ReadKey();
        }


        static void Main()
        {
            Console.Write("Номер задания(1,2):");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите строку: ");
            StringBuilder builder = new StringBuilder(Console.ReadLine());
            if (n == 1)
                Z01(builder);
            if (n == 2)
                Z02(builder);
        }
    }
}
