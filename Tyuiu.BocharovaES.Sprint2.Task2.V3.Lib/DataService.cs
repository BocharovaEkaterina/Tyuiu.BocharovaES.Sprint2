using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BocharovaES.Sprint2.Task2.V3.Lib
{
    public class DataService : ISprint2Task2V3
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((3 <= x & x <= 5) && (3 <= y & y <= 5))
                return true;
            else if ((x>=6 & x<=10) && (y==5))
                return true; 
            else if ((x==9 || x==10) && (y==3 || y==4))
                return true;
            else if ((y==3) && (x==11 || x==12))
                return true;
            else if ((x>=7 & x<=13) && (y>= 6 & y<= 8))
                return true;
            else if ((x==7 || x==8) && (y>=9 & y<=12))
                return true;
            else if ((y==9) && (x>=4 & x <= 6))
                return true;
            else if ((x==4) && (y>=10 & y<= 13))
                return true;
            else if ((y==11)&&(x==3))
                return true;
            else if ((x==11 || x==12) && (y>=9 & y<= 13))
                return true;
            else if ((x == 13) && (y >= 11 & y <= 13))
                return true;
            else
            {
                return false;
            }
            return res;
        }
    }
}
