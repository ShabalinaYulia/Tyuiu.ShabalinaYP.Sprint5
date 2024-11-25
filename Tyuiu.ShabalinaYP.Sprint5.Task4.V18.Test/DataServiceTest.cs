using Tyuiu.ShabalinaYP.Sprint5.Task4.V18.Lib;
namespace Tyuiu.ShabalinaYP.Sprint5.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\User\AppData\Local\Temp\InPutDataFileTask4V18";
            FileInfo fileInfo = new FileInfo(path);
            Assert.AreEqual(true, fileInfo.Exists);
        }
    }
}
