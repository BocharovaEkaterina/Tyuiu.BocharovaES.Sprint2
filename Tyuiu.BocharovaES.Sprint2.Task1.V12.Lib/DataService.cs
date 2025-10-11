using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BocharovaES.Sprint2.Task1.V12.Lib
{
    public class DataService : ISprint2Task1V12
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (d > c);
            res[1] = (a > b) & (c > d );
            res[2] = (a + 500 > b) || (c == d);
            res[3] = (b +100 > c) && (d > a);
            res[4] = !(res[3]);
            res[5] = (a < c) ^ (d > b);

            return res;
        }
    }
}
