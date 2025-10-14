
using Tyuiu.AlbornozJ.Sprint2.Task5.V6.Lib;

namespace Tyuiu.AlbornozJ.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();

            
            Assert.AreEqual("шестерка пик", ds.FindCardNameAndValue(1, 6)); 
            Assert.AreEqual("дама треф", ds.FindCardNameAndValue(2, 12));  
            Assert.AreEqual("туз бубен", ds.FindCardNameAndValue(3, 14));  
            Assert.AreEqual("валет червей", ds.FindCardNameAndValue(4, 11));  
            Assert.AreEqual("десятка пик", ds.FindCardNameAndValue(1, 10));    
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
                ds.FindCardNameAndValue(1, 15);
            });
        }

        [TestMethod]
        public void InvalidSuitTest()
        {
            DataService ds = new DataService();

            
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(0, 6);  
            });

           
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(5, 6);  
            });
        }
    }
}
