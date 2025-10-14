using Tyuiu.NikitinRYu.Sprint2.Task6.V4.Lib;

namespace Tyuiu.NikitinRYu.Sprint2.Task6.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Сокращенная форма оператора switch                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Никитин Р.Ю. | ИБКСб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму оператора      *");
            Console.WriteLine("* switch и вычисляет требуемое значение. Мастям игральных карт условно    *");
            Console.WriteLine("* присвоены номера: пики - 1, трефы - 2, бубны - 3, червы - 4.            *");
            Console.WriteLine("* По заданному номеру масти m (1 <= m <= 4) определить название масти.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер масти m (1-4): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string suitName = ds.FindCardSuit(m);

            Console.WriteLine($"Масть: {suitName}");

            Console.ReadKey();
        }
    }
}