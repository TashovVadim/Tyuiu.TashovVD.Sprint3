using Tyuiu.TashovVD.Sprint3.Task6.V14.Lib;

namespace Tyuiu.TashovVD.Sprint3.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            int startValue, stopValue, wait;

            startValue = 10; stopValue = 15;

            wait = 8;

            DataService ds = new DataService();
            var res = ds.GetSumTheDivisors(startValue, stopValue);

            Assert.AreEqual(wait, res);

        }
    }
}
