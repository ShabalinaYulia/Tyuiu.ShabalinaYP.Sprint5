using Tyuiu.ShabalinaYP.Sprint5.Task2.V22.Lib;
namespace Tyuiu.ShabalinaYP.Sprint5.Task2.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ChexkedExistFile()
        {
            string path = @"C:\Users\User\AppData\Local\Temp\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
