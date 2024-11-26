using Tyuiu.ShabalinaYP.Sprint5.Task7.V1.Lib;
namespace Tyuiu.ShabalinaYP.Sprint5.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.ShabalinaYP.Sprint5\DataSprint5\InPutDataFileTask7V1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
