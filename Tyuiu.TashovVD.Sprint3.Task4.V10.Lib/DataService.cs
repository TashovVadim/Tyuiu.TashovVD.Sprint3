using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TashovVD.Sprint3.Task4.V10.Lib
{
    public class DataService : ISprint3Task4V10
    {
        public double Calculate(int startValue, int stopValue)
        {
            if (startValue < -5 && stopValue > 5) return 0;
            double res = 1;

            for(int x = startValue;  x < stopValue + 1; x++)
            {
                if (x == 0)
                {
                    continue;
                }

                double y = ((Math.Sin(x) - x) / x);

                res *= y;
            }
            
            return Math.Round(res, 3);

        }
    }
}
