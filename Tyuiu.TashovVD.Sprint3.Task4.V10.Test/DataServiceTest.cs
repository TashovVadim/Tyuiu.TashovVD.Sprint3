using Tyuiu.TashovVD.Sprint3.Task4.V10.Lib;

namespace Tyuiu.TashovVD.Sprint3.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int startValue, stopValue;
            startValue = -5;
            stopValue = 5;

            double wait = 0.014;

            DataService ds = new DataService();
            double res = ds.Calculate(startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}
