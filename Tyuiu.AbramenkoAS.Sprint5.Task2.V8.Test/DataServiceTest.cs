using Tyuiu.AbramenkoAS.Sprint5.Task2.V8.Lib;
using System.IO;

namespace Tyuiu.AbramenkoAS.Sprint5.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSave()
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[3, 3] {
                { 9, 4, -6 },
                { 3, 9, 9 },
                { -6, 7, -4 }
            };

            string path = ds.SaveToFileTextData(mtrx);

            Assert.IsTrue(File.Exists(path));

            string expectedText = "1;1;0" + System.Environment.NewLine +
                                  "1;1;1" + System.Environment.NewLine +
                                  "0;1;0";

            string actualText = File.ReadAllText(path);

            Assert.AreEqual(expectedText, actualText);
        }
    }
}
