using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TashovVD.Sprint3.Task7.V1.Lib
{
    public class DataService : ISprint3Task7V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double [] res = new double[stopValue - startValue + 1];

            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    res[count] = 0;
                }
                else
                {
                    double y = (Math.Sin(x) / (x + 1.2)) + Math.Cos(x) * 7 * x - 2;
                    res[count] = Math.Round(y, 2);
                }

                count++;
            }

            return res;
        }
    }
}
