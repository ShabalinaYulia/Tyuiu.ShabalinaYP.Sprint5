using Tyuiu.ShabalinaYP.Sprint5.Task4.V18.Lib;
namespace Tyuiu.ShabalinaYP.Sprint5.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {            
            string path = @"C:\Users\User\source\repos\Tyuiu.ShabalinaYP.Sprint5\DataSprint5\InPutDataFileTask4V18.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
