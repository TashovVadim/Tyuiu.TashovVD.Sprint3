using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TashovVD.Sprint3.Task2.V10.Lib
{
    public class DataService : ISprint3Task2V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sumres = 1;
            double i = startValue;

            do
            {
                sumres *= (Math.Pow(value, i) + (1 / (i + 1)));
                i++;
            } while (i <= stopValue);

            return Math.Round(sumres, 3);
        }
    }
}
