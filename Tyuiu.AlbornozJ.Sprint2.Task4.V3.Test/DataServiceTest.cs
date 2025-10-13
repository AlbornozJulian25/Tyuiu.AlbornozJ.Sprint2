
using Tyuiu.AlbornozJ.Sprint2.Task4.V3.Lib;

namespace Tyuiu.AlbornozJ.Sprint2.Task4.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 0.942; 
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2() 
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 11.25; 
            Assert.AreEqual(wait, res);
        }
    }
}
