using System.IO;
using Tyuiu.AbramenkoAS.Sprint5.Task1.V27.Lib;

namespace Tyuiu.AbramenkoAS.Sprint5.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(-5, 5);

            Assert.IsTrue(File.Exists(path));
        }
    }
}
