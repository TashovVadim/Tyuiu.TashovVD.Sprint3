using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TashovVD.Sprint3.Task6.V14.Lib
{
    public class DataService : ISprint3Task6V14
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int res = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                for(int d = 1; d <= Convert.ToInt32(Math.Sqrt(i)); d++)
                {
                    if ((i % d) == 0)
                    {
                        if (d > 5) 
                        {
                            res++;
                        }
                        if ((i / d) > 5)
                        {
                            res++;
                        }
                    }
                } 
            }

            return res;
        }
    }
}
