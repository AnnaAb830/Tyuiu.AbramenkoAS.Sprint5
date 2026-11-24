using System.IO;
using Tyuiu.AbramenkoAS.Sprint5.Task4.V19.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.AbramenkoAS.Sprint5.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string folderPath = @"C:\DataSprint5";
            string fileName = "InPutDataFileTask4V19.txt";
            string path = Path.Combine(folderPath, fileName);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.IsTrue(fileExists);
        }
    }
}
