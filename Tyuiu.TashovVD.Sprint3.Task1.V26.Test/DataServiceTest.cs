using Tyuiu.TashovVD.Sprint3.Task1.V26.Lib;

namespace Tyuiu.TashovVD.Sprint3.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            int value = 5;
            int startValue, endValue;
            startValue = 1;
            endValue = 2;
            double wait = 1.498;
            DataService ds = new DataService();
            var res = ds.GetSumSeries(value, startValue, endValue);
            Assert.AreEqual(wait, res);
        }
    }
}
