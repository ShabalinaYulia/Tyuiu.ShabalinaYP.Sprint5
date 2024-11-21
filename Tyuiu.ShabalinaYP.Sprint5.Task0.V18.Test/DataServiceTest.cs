using System.Diagnostics;
namespace Tyuiu.ShabalinaYP.Sprint5.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\User\AppData\Local\Temp\OutPutFileTask0.txt"; 
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists  = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
