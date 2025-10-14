namespace Tyuiu.NikitinRYu.Sprint2.Task6.V4.Lib
{
    public class DataService
    {
        public string FindCardSuit(int m)
        {
            return m switch
            {
                1 => "пики",
                2 => "трефы",
                3 => "бубны",
                4 => "червы",
                _ => "недопустимый номер масти" // или выбросить исключение
            };
        }
    }
}
