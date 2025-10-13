using Tyuiu.BocharovaES.Sprint2.Task4.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Бочарова Е. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Тернарный оператор                                                *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнила: Бочарова Екатерина Сергеевна | ИИПб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ :                                                               *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
        Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение   *");
        Console.WriteLine("* переменных X и Y с клавиатуры. Округлить полученное значение до         *");
        Console.WriteLine("* до трех знаков после запятой;                                           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение X:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение переменной Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        double res = ds.Calculate(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Значение функции = " + res);

        Console.ReadKey();
    }
}