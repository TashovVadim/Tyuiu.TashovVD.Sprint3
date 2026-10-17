using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TashovVD.Sprint3.Task3.V4.Lib
{
    public class DataService : ISprint3Task3V4
    {
        public string DeleteCharInString(string value, char item)
        {
            string newValue = "";

            foreach (char chr in value)
            {
                if (chr != item)
                {
                    newValue += chr;
                }

            }

            return newValue;
        }
    }
}
