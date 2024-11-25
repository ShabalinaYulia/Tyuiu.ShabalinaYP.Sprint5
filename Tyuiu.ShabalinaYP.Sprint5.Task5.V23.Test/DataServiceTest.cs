using Tyuiu.ShabalinaYP.Sprint5.Task5.V23.Lib;
namespace Tyuiu.ShabalinaYP.Sprint5.Task5.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            DataService dataService = new DataService();
            string path = @"C:\DataSprint5";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
