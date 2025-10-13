using Tyuiu.BocharovaES.Sprint2.Task5.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнила: Бочарова Е. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор switch                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
        Console.WriteLine("* Выполнила: Бочарова Екатерина Сергеевна | ИИПб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ :                                                               *");
        Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами: m       *");
        Console.WriteLine("* (порядковый номер месяца) и n (число). По заданным n и m определить дату*");
        Console.WriteLine("* следующего дня (принять, что n и m не характеризуют 31 декабря)         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("Введите текущеее число(в феврале до 28 включительно):");
        int n = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Введите текущий месяц:");
        int m = Convert.ToInt32(Console.ReadLine());

        string res = ds.FindDateOfNextDay(m, n);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        if (n > 0 && n < 32 && m > 0 && m < 13)
        {
            Console.WriteLine("Дата следующего дня:" + res);
        }
        else if (m<1 || m>12)
            Console.WriteLine("Неправильный номер месяца");
        else if (n < 1 || n > 31)
            Console.WriteLine("Неправильный номер числа");
        Console.ReadKey();

    }
}