using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program1
{
    class Program
    {
        static void z01(string[] text)
        {
            foreach (var item in text)
            {
                if (item[0] == text[text.Length - 1][0]) Console.WriteLine(item);
            }

        }
        static void Main(string[] args)

        {
            string text = File.ReadAllText("../../../text.txt");
            string[] text_arr = text.Split(' ');
            Console.Write("Номер задания(1,2): ");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
                z01(text_arr);
            if (n == 2)
                z02(text); 
        }
        static void z02(string text)
        {       
            int x = 0;
            text = text.Where(i =>
            {
                if (++x == 2)
                    x = 0;
                return (x != 0);
            }).Aggregate("", (acc, y) => acc + y);
            File.WriteAllText("../../../output.txt",text);
        }

    }
}
