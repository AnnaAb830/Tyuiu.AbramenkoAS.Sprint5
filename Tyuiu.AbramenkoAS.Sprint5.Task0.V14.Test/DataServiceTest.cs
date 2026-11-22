using Tyuiu.AbramenkoAS.Sprint5.Task0.V14.Lib;

namespace Tyuiu.AbramenkoAS.Sprint5.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);
            Assert.IsTrue(File.Exists(path));
            string result = File.ReadAllText(path);
            Assert.AreEqual("4,154", result);
        }
    }
}
