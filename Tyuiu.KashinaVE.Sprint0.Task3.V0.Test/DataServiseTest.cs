using Tyuiu.KashinaVE.Sprint0.Task3.V0.Lib;

namespace Tyuiu.KashinaVE.Sprint0.Task3.V0.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void CheckValid()
        {
            Assert.AreEqual(10, DataServise.Sum(5, 5));
        }
    }
}
