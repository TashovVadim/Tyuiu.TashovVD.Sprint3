using Tyuiu.TashovVD.Sprint3.Task7.V1.Lib;

namespace Tyuiu.TashovVD.Sprint3.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            int startValue, stopValue;
            startValue = -3;
            stopValue = 3;

            double[] wait = new double[7];

            wait[0] = 18.87;
            wait[1] = 4.96;
            wait[2] = -9.99;
            wait[3] = 0.00;
            wait[4] = 2.16;
            wait[5] = -7.54;
            wait[6] = -22.76;

            DataService ds = new DataService();


            var res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
