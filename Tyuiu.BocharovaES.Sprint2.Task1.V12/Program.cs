using Tyuiu.BocharovaES.Sprint2.Task1.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int a = 152;
        int b = 116;
        int c = 887;
        int d = 556;

        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);

        Console.Title = "Спринт #2 | Выполнила: Бочарова Е. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Логические операции                                               *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнила: Бочарова Екатерина Сергеевна | ИИПб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ :                                                               *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
        Console.WriteLine("* последовательность операций не должна нарушаться) и логических          *");
        Console.WriteLine("* операций (|, &, ||, &&, !, ^, последовательность операций не должна     *");
        Console.WriteLine("* нарушаться), а также арифметических выражений, которая вернет           *");
        Console.WriteLine("* логическую последовательность(массив): (True, True, True, False,        *");
        Console.WriteLine("* True, False), при a = 152, b = 116, c = 887, d = 556                    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
        Console.WriteLine("d = " + d);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();

    }
}