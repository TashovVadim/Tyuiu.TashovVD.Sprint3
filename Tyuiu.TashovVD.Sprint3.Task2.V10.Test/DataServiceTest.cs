using Tyuiu.TashovVD.Sprint3.Task2.V10.Lib;

namespace Tyuiu.TashovVD.Sprint3.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            int value = 1;
            int startValue, endValue;
            startValue = 1;
            endValue = 2;
            double wait = 2;
            DataService ds = new DataService();
            var res = ds.GetMultiplySeries(value, startValue, endValue);
            Assert.AreEqual(wait, res);
        }
    }
}
