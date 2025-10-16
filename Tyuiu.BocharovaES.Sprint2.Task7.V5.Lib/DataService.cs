using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BocharovaES.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (((x>=0) && (y>= Math.Pow(x,2)) && (y<=Math.Pow(Math.E,-x))) || ((x <= 0) && (y>=Math.Pow(x, 2)) && (y <= Math.Pow(Math.E, x))))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
