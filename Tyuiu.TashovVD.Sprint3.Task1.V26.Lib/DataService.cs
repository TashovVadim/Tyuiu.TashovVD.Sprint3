using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TashovVD.Sprint3.Task1.V26.Lib
{
    public class DataService : ISprint3Task1V26
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumres = 0;

            while (startValue <= stopValue)
            {
                sumres += Math.Pow((6 / Math.Pow(value, startValue)), 2);
                startValue++;
            }

            return Math.Round(sumres, 3);
        }
    }
}
