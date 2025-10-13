
using Tyuiu.AlbornozJ.Sprint2.Task3.V10.Lib;

namespace Tyuiu.AlbornozJ.Sprint2.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 6.333; 
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2() 
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = -1; 
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3() 
        {
            DataService ds = new DataService();
            double x = -2;
            double res = ds.Calculate(x);
            double wait = 0.036; 
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4() 
        {
            DataService ds = new DataService();
            double x = -20;
            double res = ds.Calculate(x);
            double wait = -219.95; 
            Assert.AreEqual(wait, res);
        }
    }
}
