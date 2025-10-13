using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BocharovaES.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            string res;
            string x;
            
            switch (n)
            {
                case 1:
                    n++;
                    break;
                case 2:
                    n++;
                    break;
                case 3:
                    n++;
                    break;
                case 4:
                    n++;
                    break;
                case 5:
                    n++;
                    break;
                case 6:
                    n++;
                    break;
                case 7:
                    n++;
                    break;
                case 8:
                    n++;
                    break;
                case 9:
                    n++;
                    break;
                case 10:
                    n++;
                    break;
                case 11:
                    n++;
                    break;
                case 12:
                    n++;
                    break;
                case 13:
                    n++;
                    break;
                case 14:
                    n++;
                    break;
                case 15:
                    n++;
                    break;
                case 16:
                    n++;
                    break;
                case 17:
                    n++;
                    break;
                case 18:
                    n++;
                    break;
                case 19:
                    n++;
                    break;
                case 20:
                    n++;
                    break;
                case 21:
                    n++;
                    break;
                case 22:
                    n++;
                    break;
                case 23:
                    n++;
                    break;
                case 24:
                    n++;
                    break;
                case 25:
                    n++;
                    break;
                case 26:
                    n++;
                    break;
                case 27:
                    n++;
                    break;
                case 28:
                    if (m == 2)
                    {
                        m++;
                        n = 1;
                    }
                    else
                        n++;
                    break;
                case 29:
                    n++;
                    break;
                case 30:
                    if ((m == 4) || (m == 6) || (m == 9) || (m == 11))
                    {
                        m++;
                        n = 1;
                    }
                    else
                        n++;
                    break;
                case 31:
                    m++;
                    n = 1;
                    break;
                default:
                    throw new ArgumentException($"День должен быть от 1 до 31. Значение {n}");
            }
            switch (m)
            {
                case 1:
                    res = "01.";
                    break;
                case 2:
                    res = "02.";
                    break;
                case 3:
                    res = "03.";
                    break;
                case 4:
                    res = "04.";
                    break;
                case 5:
                    res = "05.";
                    break;
                case 6:
                    res = "06.";
                    break;
                case 7:
                    res = "07.";
                    break;
                case 8:
                    res = "08.";
                    break;
                case 9:
                    res = "09.";
                    break;
                case 10:
                    res = "10.";
                    break;
                case 11:
                    res = "11.";
                    break;
                case 12:
                    res = "12.";
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
            }

            string s;
            if (n < 10)
                s = "0" + n.ToString();
            else
                s = n.ToString();
            res = res + s;
            return res;
        }
    }
}
