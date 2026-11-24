using System.IO;
using Tyuiu.AbramenkoAS.Sprint5.Task7.V11.Lib;

namespace Tyuiu.AbramenkoAS.Sprint5.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V11.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.IsTrue(fileExists);
        }
    }
}
