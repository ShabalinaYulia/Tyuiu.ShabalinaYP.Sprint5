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
            int res = ds.LoadFromDataFile(path);
        }
    }
}
