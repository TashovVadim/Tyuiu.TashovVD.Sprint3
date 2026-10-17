using Tyuiu.TashovVD.Sprint3.Task0.V12.Lib;

namespace Tyuiu.TashovVD.Sprint3.Task0.V12.Test
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
            endValue = 13;
            double wait = 7.5;
            DataService ds = new DataService();
            var res = ds.GetMultiplySeries(value, startValue, endValue);
            Assert.AreEqual(wait, res);
        }
    }
}
