using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0, B = 0, C = 0, D = 0; // Объявление целых чисел
            double srt = 0.0;
            Console.WriteLine("Введите числа A B C D");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            srt = (double)(A + B + C + D) / 4; // считаем ср.арифм.
            if (A - srt < 2)
            {
                Console.WriteLine("Выводим число А: " + A);
                Console.WriteLine("Так как оно соответствует требованием задачи.");
            }
            if (B - srt < 2)
            {
                Console.WriteLine("Выводим число B: " + B);
                Console.WriteLine("Так как оно соответствует требованием задачи.");
            }

            if (C - srt < 2)
            {
                Console.WriteLine("Выводим число C: " + C);
                Console.WriteLine("Так как оно соответствует требованием задачи.");
            }

            if (D - srt < 2)
            {
                Console.WriteLine("Выводим число D: " + D);
                Console.WriteLine("Так как оно соответствует требованием задачи.");
            }
            Console.ReadLine();

        }
    }
}
