using Tyuiu.ShabalinaYP.Sprint5.Task6.V17.Lib;
namespace Tyuiu.ShabalinaYP.Sprint5.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCount()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\User\source\repos\Tyuiu.ShabalinaYP.Sprint5\DataSprint5\InPutDataFileTask6V17.txt";
            int res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.ShabalinaYP.Sprint5\DataSprint5\InPutDataFileTask6V17.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
