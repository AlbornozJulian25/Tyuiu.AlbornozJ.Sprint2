
using Tyuiu.AlbornozJ.Sprint2.Task5.V6.Lib;

namespace Tyuiu.AlbornozJ.Sprint2.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Шестерка пик", ds.FindCardNameAndValue(6, 1));
            Assert.AreEqual("Дама треф", ds.FindCardNameAndValue(12, 2));
            Assert.AreEqual("Туз бубен", ds.FindCardNameAndValue(14, 3));
            Assert.AreEqual("Валет червей", ds.FindCardNameAndValue(11, 4));
            Assert.AreEqual("Десятка пик", ds.FindCardNameAndValue(10, 1));
        }

        [TestMethod]
        public void InvalidValueTest()
        {
            DataService ds = new DataService();

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(1, 1);
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(15, 1);
            });
        }

        [TestMethod]
        public void InvalidSuitTest()
        {
            DataService ds = new DataService();

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(6, 0);
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(6, 5);
            });
        }
    }
}
