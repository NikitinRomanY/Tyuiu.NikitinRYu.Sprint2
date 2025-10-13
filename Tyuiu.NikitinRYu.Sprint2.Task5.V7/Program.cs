using Tyuiu.NikitinRYu.Sprint2.Task5.V7.Lib;

namespace Tyuiu.NikitinRYu.Sprint2.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Никитин Р.Ю. | ИБКСб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch и вычисляет      *");
            Console.WriteLine("* требуемое значение. С начала startYear года по некоторый день прошло    *");
            Console.WriteLine("* n месяцев и 2 дня. Определить название месяца этого дня.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите начальный год startYear: ");
            int startYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество прошедших месяцев n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string monthName = ds.FindMonthName(startYear, n);

            Console.WriteLine($"Название месяца: {monthName}");

            Console.ReadKey();
        }
    }
}