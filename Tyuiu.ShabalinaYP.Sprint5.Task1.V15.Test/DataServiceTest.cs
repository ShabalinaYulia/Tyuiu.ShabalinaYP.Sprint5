using Tyuiu.ShabalinaYP.Sprint5.Task1.V15.Lib;
namespace Tyuiu.ShabalinaYP.Sprint5.Task1.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ChexkedExistFile()
        {
            string path = @"C:\Users\User\AppData\Local\Temp\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
