using System;

namespace v19
{
    class v19
    {
        static void Summ()
        {
            Console.Write("Первый член геометрической прогрессии: ");
            float b1 = float.Parse(Console.ReadLine());
            Console.Write("Знаменатель: ");
            float q = float.Parse(Console.ReadLine());
            Console.Write("Число членов прогрессии: ");
            int n = int.Parse(Console.ReadLine());
            double qn = 0;
            double s = 0;
            if (q != 1)
            {
                if (q > 0)
                    qn = Math.Exp(Math.Log(q) * n);
                else
                    if (q < 0)
                        qn = -Math.Exp(Math.Log(-q) * n);
                    else
                        qn = 0;
                s = b1 * (1 - qn) / (1 - q);
            }
            Console.WriteLine("Сумма членов геометрической прогрессии: " + s);
        }
        static void Equilateral()
        {
            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            float c = float.Parse(Console.ReadLine());
            if (a == b && b == c)
                Console.WriteLine("Треугольник равносторонний");
            else
                Console.WriteLine("Треугольник не равносторонний");
        }

        static void Main()
        {
            Console.Write("Номер задания(1,2): ");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
                Summ();
            if (n == 2)
                Equilateral();
        }
    }
}