using Tyuiu.TashovVD.Sprint3.Task5.V23.Lib;

namespace Tyuiu.TashovVD.Sprint3.Task5.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            int x, startValue1, startValue2, stopValue1, stopValue2;

            x = 2; startValue1 = 1; startValue2 = 1; stopValue1 = 2; stopValue2 = 2;

            double wait = -0.671;

            DataService ds = new DataService();
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Assert.AreEqual(res, wait);

        }
    }
}
