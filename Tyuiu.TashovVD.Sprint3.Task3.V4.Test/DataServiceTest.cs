using Tyuiu.TashovVD.Sprint3.Task3.V4.Lib;

namespace Tyuiu.TashovVD.Sprint3.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            char item = 'j';
            string str = "plkjjdw cvjkl";
            string wait = "plkdw cvkl";
            DataService ds = new DataService();
            var res = ds.DeleteCharInString(str, item);
            Assert.AreEqual(wait, res);
        }
    }
}
