using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TashovVD.Sprint3.Task0.V12.Lib
{
    public class DataService : ISprint3Task0V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {

            int i;
            double sumres = 0;

            for (i = startValue; i <= stopValue; i++)
            {
                sumres += (Math.Pow(value, i) + (1 / (i + 1)));
            }

            return sumres;
            
        }
    }
}
